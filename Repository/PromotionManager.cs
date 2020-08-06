using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.Utilities.Enums;

namespace PromotionEngine.Repository
{
   public class PromotionManager
    {
        public IPromotionRepository GetPromotionInstance(char promoType)
        {
            if (promoType.Equals(PromoType.TypeA))
            {
                return new PromotionTypeARepository();
            }
            else if (promoType.Equals(PromoType.TypeB))
            {
                return new PromotionTypeBRepository();
            }
            else 
            {
                //If some new promotion needs to be introduced in future
                return new PromotionTypeCRepository();
            }

        }
    }
}
