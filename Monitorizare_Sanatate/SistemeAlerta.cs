using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorizare_Sanatate
{
    internal class SistemeAlerta
    {
        public void VerificareGlicemie(MasuratoriGlicemie masuratori)
        {
            if (masuratori.ValoareGlicemie<70)
            {
                Console.WriteLine($"Alerta! Glicemie scazuta pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare:{masuratori.ValoareGlicemie} {masuratori.UnitateMasura}");

            }
            else if (masuratori.ValoareGlicemie>180)
            {
                Console.WriteLine($"Alerta! Glicemie crescuta pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare: {masuratori.ValoareGlicemie} {masuratori.UnitateMasura}");

            }
        }

        public void VerificareTensiune(MasuratoriCardiovasculare masuratori)
        {
            if (masuratori.TensiuneaSistolica>140 || masuratori.TensiuneaDiastolica>90 )
            {
                Console.WriteLine($"Alerta! Tensiune arteriala crescuta pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare: {masuratori.TensiuneaSistolica}/{masuratori.TensiuneaDiastolica} mmHg");
            }
            else if (masuratori.TensiuneaSistolica<90 || masuratori.TensiuneaDiastolica<60)
            {
                Console.WriteLine($"Alerta!Tensiune arteriala scazuta pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare: {masuratori.TensiuneaSistolica}/{masuratori.TensiuneaDiastolica} mmHg");

            }
        }


        public void VerificarePuls(MasuratoriCardiovasculare masuratori)
        {
            if(masuratori.Puls>100)
            {
                Console.WriteLine($"Alerta!Puls crescut pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare:{masuratori.Puls}bpm");


            }
            else if(masuratori.Puls<60)
            {
                Console.WriteLine($"Alerta!Puls scazut pentru pacientul {masuratori.Pacient.Nume} {masuratori.Pacient.Prenume}. Valoare:{masuratori.Puls}bpm");
            }
        }
        
    }
}
