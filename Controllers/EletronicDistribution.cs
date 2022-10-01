using System;
using API.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

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

        public static int getFamilyId(string s) 
        {
            if (s == "Li" || s == "Na" || s == "K" || s == "Rb" || s == "Cs" || s == "Fr") {
                return 1;
            }
            else if (s == "Be" || s == "Ca" || s == "Mg" || s == "Sr" || s == "Ba" || s == "Ra") {
                return 2;
            }
            else if (s == "B" || s == "Al" || s == "Ga" || s == "In" || s == "Tl") {
                return 13;
            }
            else if (s == "C" || s == "Si" || s == "Ge" || s == "Sn" || s == "Pb") {
                return 14;
            }
            else if (s == "N" || s == "P" || s == "As" || s == "Sb" || s == "Bi" || s == "") {
                return 15;
            }
            else if (s == "O" || s == "S" || s == "Se" || s == "Te" || s == "Po") {
                return 16;
            }
            else if (s == "F" || s == "Cl" || s == "Br" || s == "I" || s == "At") {
                return 17;
            }
            else if (s == "He" || s == "Ne" || s == "Ar" || s == "Kr" || s == "Xe" || s == "Rn") {
                return 18;
            }
            else if (s == "La" || s == "Ce" || s == "Pr" || s == "Nd" || s == "Pm" || s == "Sm") {
                return 19;
            }
            else if (s == "Eu" || s == "Gd" || s == "Tb" || s == "Dy" || s == "Ho" || s == "Er") {
                return 19;
            }
            else if (s == "Tm" || s == "Yb") {
                return 19;
            }
            else if (s == "Ac" || s == "Th" || s == "Pa" || s == "U" || s == "Np" || s == "Pu") {
                return 20;
            } 
            else if (s == "Am" || s == "Cm" || s == "Bk" || s == "Cf" || s == "Es" || s == "Fm") {
                return 20;
            } 
            else if (s == "Md" || s == "No") {
                return 20;
            } else {
                return 4;
            }
        }

        public static Family getFamily(string s,DataContext _context) 
        {
            var id = getFamilyId(s);
            Family family = _context.Families.
                FirstOrDefault(f => f.Id.Equals(id));
            return family;
        }
    }
}