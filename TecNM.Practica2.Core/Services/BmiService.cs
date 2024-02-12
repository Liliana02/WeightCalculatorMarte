using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Services;

public class BmiService : IBmiService{
    public Bmi ProcessBmi(Person person){
        var bmi = new Bmi();
        bmi.PesoM = (person.Peso/9.81f) * 3.711f;
        return bmi;
    }
}
