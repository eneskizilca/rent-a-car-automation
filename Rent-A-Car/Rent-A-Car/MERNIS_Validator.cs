using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    class MERNIS_Validator
    {
        public bool TCKimlikNoDogrula(string tckn)
        {
            // TC Kimlik No 11 haneli olmalıdır
            if (tckn.Length != 11 || !long.TryParse(tckn, out _))
                return false;

            // İlk hane 0 olamaz
            if (tckn[0] == '0')
                return false;

            // TC Kimlik No'nun rakamlarını int array olarak al
            int[] nums = tckn.Select(c => int.Parse(c.ToString())).ToArray();

            // 1., 3., 5., 7. ve 9. hanelerin toplamı
            int toplamTek = nums[0] + nums[2] + nums[4] + nums[6] + nums[8];

            // 2., 4., 6. ve 8. hanelerin toplamı
            int toplamCift = nums[1] + nums[3] + nums[5] + nums[7];

            // 10. hane kontrolü: (toplamTek * 7 - toplamCift) % 10
            int hane10 = ((toplamTek * 7) - toplamCift) % 10;

            // 11. hane kontrolü: (toplamTek + toplamCift + hane10) % 10
            int hane11 = (toplamTek + toplamCift + nums[9]) % 10;

            // 10. ve 11. haneler doğru mu?
            return nums[9] == hane10 && nums[10] == hane11;
        }
    }
}
