using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks
{
    public class Diversao
    {
        public double previsao(List<Tarefa> done, int storyPoints)
        {
            double tempoEmSec = 0, tempoToReturn =0;
            int auxMedia = 0;
            foreach(Tarefa tarefa in done)
            {
                if(tarefa.StoryPoints == storyPoints)
                {
                    TimeSpan intervalo = tarefa.DataRealFim - tarefa.DataRealInicio;
                    tempoEmSec += intervalo.TotalSeconds;
                    auxMedia++;
                }
            }
            if(tempoEmSec > 0)
            {
                tempoToReturn = tempoEmSec / auxMedia;
            }
            else
            {
                HashSet<int> usedValues = new HashSet<int>();
                int closest = 0;
                do
                {
                    closest = GetClosestUnused(storyPoints, usedValues);
                    foreach (Tarefa tarefa in done)
                    {
                        if (tarefa.StoryPoints == closest)
                        {
                            TimeSpan intervalo = tarefa.DataRealFim - tarefa.DataRealInicio;
                            tempoEmSec += intervalo.TotalSeconds;
                            auxMedia++;
                        }
                    }
                } while (auxMedia <= 0);

                double auxtempo = tempoEmSec / auxMedia;

                int aux = 0;
                if (closest > storyPoints)
                {
                    //pegou um tempo de um story point maior entao divisao
                    aux = closest - storyPoints;
                    tempoToReturn = auxtempo / aux;
                }
                else
                {
                    //pegou um tempo de um sotry point menor entao multiplicaçao
                    aux = storyPoints - closest;
                    tempoToReturn = auxtempo * aux;
                }
            }

            return tempoToReturn;
        }

        int GetClosestUnused(int target, HashSet<int> usedValues)
        {
            int[] values = { 1, 2, 3, 5, 8, 13, 21 };
            var closest = values
                .Where(v => v != target && !usedValues.Contains(v))  // exclude exact and used
                .OrderBy(v => Math.Abs(v - target))
                .FirstOrDefault();  // returns 0 if nothing is found

            if (closest != 0) usedValues.Add(closest);

            return closest;
        }
    }
}
