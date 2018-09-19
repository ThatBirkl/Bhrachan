using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

namespace Abilities
{
      //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
     //++++++++++++++++++++++++++++ SWORD ++++++++++++++++++++++++++++//
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

    //+++++ ACTIVE +++++//
    public class Parry : ActiveAbility
    {
        public Parry()
        {
            //Ability stats
            abilityId = "59376479-E196-448D-AE4F-C0CDBDC41D58";
            type = Type.AbilityType.sword;
            name = "Parry";
            healthBalance = 0;
            radius = 1;
            aoe = 0;
            damageReduction = 10;
            primarySkill = Type.PrimarySkill.strength;
            secondarySkill = Type.SecondarySkill.sword;
            tier = Type.Tier.common;
            //ActiveAbility stats
            energyCost = -1;
            penaltySec = -1;
            maxNumTargets = 1;
        }

        public override void Execute(b_Character caster, b_Character[] targets)
        {
            base.Execute(caster, targets);
            float chance = 0.1f + (0.1f * caster.GetSkill(primarySkill));
            caster.AddBlockMarker(new BlockMarker(Util.MapSecondarySkillToSkillname(secondarySkill), damageReduction, chance, maxNumTargets));
        }
    }

    public class Strike : ActiveAbility
    {
        public Strike()
        {
            //Ability stats
            abilityId = "5D6B7D52-A044-4CE6-B1D9-CB930889F5A5";
            type = Type.AbilityType.sword;
            name = "Strike";
            healthBalance = -30;
            radius = 1;
            aoe = 0;
            damageReduction = 0;
            primarySkill = Type.PrimarySkill.strength;
            secondarySkill = Type.SecondarySkill.sword;
            tier = Type.Tier.common;
            //ActiveAbility stats
            energyCost = 3;
            penaltySec = 30;
            maxNumTargets = 1;
        }

        public override void Execute(b_Character caster, params b_Character[] targets)
        {
            base.Execute(caster, targets);
            //for strike targets is only one so:
            b_Character target = targets[0];
            int damage = Mathf.Abs(healthBalance) + Mathf.RoundToInt((Mathf.Abs(healthBalance) * 0.1f * caster.GetSkill(primarySkill)) + (Mathf.Abs(healthBalance) * 0.1f * caster.GetSkill(secondarySkill)));
            target.AddHealth(- damage);
        }
    }
    //+++++ PASSIVE +++++//
}
