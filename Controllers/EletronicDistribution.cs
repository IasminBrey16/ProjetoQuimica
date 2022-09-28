using System;

namespace API
{
    public class EletronicDistribution
    {
        public static string Calcular(int z)
        {
            int[] camada = {1,2,2,3,3,4,3,4,5,4,5,6,4,5,6,7,5,6,7};
            string distribuicao = "";
            do
            {
                for (int i = 0; i < 18; i++)
                {
                    if ( i==0 || i==1 || i==3 || i==5 || i==8 || i==11 || i==15)
                    {
                        distribuicao = distribuicao + Convert.ToString(camada[i]);
                        if ( z > 2)
                        {
                            distribuicao = distribuicao + "s2 ";
                            z = z - 2;
                        } else {
                            distribuicao = distribuicao + "s" + Convert.ToString(z) + " ";
                            return distribuicao;
                        }
                    } else if (i==2 || i==4 || i==7 || i==10 || i==14 || i==18)
                    {
                        distribuicao = distribuicao +  Convert.ToString(camada[i]);
                        if ( z > 6)
                        {
                            distribuicao = distribuicao + "p6 ";
                            z = z - 6;
                        } else {
                            distribuicao = distribuicao + "p" + Convert.ToString(z) + " ";
                            return distribuicao;
                        }
                    } else if (i==6 || i==9 || i==13 || i==17)
                    {
                        distribuicao = distribuicao +  Convert.ToString(camada[i]);
                        if (z > 10)
                        {
                            distribuicao = distribuicao + "d10 ";
                            z = z - 10;
                        } else {
                            distribuicao = distribuicao + "d" + Convert.ToString(z) + " ";
                            return distribuicao;
                        }
                    } else if (i==12 || i==14)
                    {
                        distribuicao = distribuicao +  Convert.ToString(camada[i]);
                        if (z > 14)
                        {
                            distribuicao = distribuicao + "f14 ";
                            z = z - 14;
                        } else {
                            distribuicao = distribuicao + "f" + Convert.ToString(z) + " ";
                            return distribuicao;
                        }
                    }
                }
                return distribuicao;
            } while (z != 0);
        }

        public static int ReturnGroup(string s) {
            if (s == "Li" || s == "Na" || s == "K" || s == "Rb" || s == "Cs" || s == "Fr") {
                return 1;
            }
            return 0;
        }
        public static void ReturnFamilyId() {}
    }
}