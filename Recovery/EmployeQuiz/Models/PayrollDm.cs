using System;
using System.Collections.Generic;
//exportar espacio de nombres
using System.IO;
using System.Linq;
using System.Web;

namespace EmployeQuiz.Models
{
    //que dialoja el origen de datos
    public class PayrollDm
    {
        //lista de empleados
        //extraer una lista de datos
        List<Employe> empList;

        //constructor del Modelo
        public PayrollDm(string dbPath)
        {
            //creado del objeto de la lista empleados
            empList = new List<Employe>();

            //leer el archivo
            var reader = new StreamReader(
                File.OpenRead(dbPath));

            //leer y parsear
            while (!reader.EndOfStream)
            {
                //leo una linea
                var line = reader.ReadLine();

                //parsear
                //separar los valores y guardar en un objeto
                var valores = line.Split(',');
                empList.Add(
                    new Employe
                    {
                        Id = valores[0],
                        Name =valores[3],
                        Position = valores[4],
                        FirstLastname = valores[1],
                        SecondLastname = valores[2],
                        Sex = char.Parse(valores[6]),
                        PhotoPath = valores[7],
                        Wage = double.Parse(valores[5]),
                    }
                
                    );
             }
          }
          //Acseder
          public Employe GuetEmployeeById(string id)
          {
              //SE PUEDE HACER DE ESTA FORMA TRADICIONAL//

           //  Employe emp = null;
           //  foreach (var empleadin in empList)
           //  {
           //      if (id == empleadin.Id)
           //      {
           //          emp = empleadin;
           //      }
           //  }
           //  return emp;

              //O DE ESTA FORMA LANDAN EXPRECION
              var emp = empList.Find(e => e.Id == id);
                  return emp;
          }
     }
  }
