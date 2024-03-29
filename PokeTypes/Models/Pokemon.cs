﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokeTypes.Models {
    public class Pokemon {
        [Key]
        public int Id { get; set; }
        public string PokemonName { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }

        public string[] types = { "normal", "fighting", "flying", "poison", "ground",
                                         "rock", "bug", "ghost", "steel", "fire", "water",
                                         "grass", "electric", "psychic", "ice", "dragon",
                                         "dark", "fairy" };

        public string[] typeEffectivenessStr(string str1, string str2) {
            double[] te = typeEffectiveness(str1, str2);
            string[] ans = new string[te.Length];
            for(int i=0; i<te.Length; i++) {
                ans[i] = types[i] + ": "+ te[i].ToString();
                ans[i] = ans[i].First().ToString().ToUpper() + ans[i].Substring(1);
            }

            return ans;
        }
        public double[] typeEffectiveness(string str1, string str2) {
            double[,] s = {{1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                          { 1, 1, 2, 1, 1, .5, .5, 1, 1, 1, 1, 1, 1, 2, 1, 1, .5, 2 },
                          { 1, .5, 1, 1, 0, 2, .5, 1, 1, 1, 1, .5, 2, 1, 2, 1, 1, 1 },
                          { 1, .5, 1, .5, 2, 1, .5, 1, 1, 1, 1, .5, 1, 2, 1, 1, 1, .5 },
                          { 1, 1, 1, .5, 1, .5, 1, 1, 1, 1, 2, 2, 0, 1, 2, 1, 1, 1 },
                          { .5, 2, .5, .5, 2, 1, 1, 1, 2, .5, 2, 2, 1, 1, 1, 1, 1, 1 },
                          { 1, .5, 2, 1, .5, 2, 1, 1, 1, 2, 1, .5, 1, 1, 1, 1, 1, 1 },
                          { 0, 0, 1, .5, 1, 1, .5, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1 },
                          { .5, 2, .5, 0, 2, .5, .5, 1, .5, 2, 1, .5, 1, .5, .5, .5, 1, .5 },
                          { 1, 1, 1, 1, 2, 2, .5, 1, .5, .5, 2, .5, 1, 1, .5, 1, 1, .5 },
                          { 1, 1, 1, 1, 1, 1, 1, 1, .5, .5, .5, 2, 2, 1, .5, 1, 1, 1 },
                          { 1, 1, 2, 2, .5, 1, 2, 1, 1, 2, .5, .5, .5, 1, 2, 1, 1, 1 },
                          { 1, 1, .5, 1, 2, 1, 1, 1, .5, 1, 1, 1, .5, 1, 1, 1, 1, 1 },
                          { 1, .5, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, .5, 1, 1, 2, 1 },
                          { 1, 2, 1, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, .5, 1, 1, 1 },
                          { 1, 1, 1, 1, 1, 1, 1, 1, 1, .5, .5, .5, .5, 1, 2, 2, 1, 2 },
                          { 1, 2, 1, 1, 1, 1, 2, .5, 1, 1, 1, 1, 1, 0, 1, 1, .5, 2 },
                          { 1, .5, 1, 2, 1, 1, .5, 1, 2, 1, 1, 1, 1, 1, 1, 0, .5, 1 } };

            int indexA = 0;
            int indexB = 0;


            double[] f = new double[18];

            

            for (int i = 0; i < types.Length; i++)
            {
                if (str1 == types[i])
                {
                    indexA = i;
                }
                if (str2 == types[i])
                {
                    indexB = i;
                }
            }


            for (int i = 0; i < 18; i++)
            {
                if (str2 == "") {
                    f[i] = s[indexA, i];
                } else {
                    f[i] = s[indexA, i] * s[indexB, i];
                }
            }

            

            return f;

        }




    }
}