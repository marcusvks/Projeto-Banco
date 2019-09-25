using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Treinamento;
using Treinamento._3___DAO.DAOSQL;

namespace TransformaArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            METODO1();
            //METODO2();

            AgenciaDaoSql sqldao = new AgenciaDaoSql();

            string path = @"C:\Users\marcus.kayser\Desktop\arquivostreinamento\bunda.xml";
            List<Agencia> bunda = sqldao.ListaDados();



            //List<Agencia> deserialize = JsonConvert.DeserializeObject<List<Agencia>>(a);

        }

        private static void METODO2()
        {
            AgenciaDaoSql sqldao = new AgenciaDaoSql();

            string path = @"C:\Users\marcus.kayser\Desktop\arquivostreinamento\bunda.xml";
            List<Agencia> bunda = sqldao.ListaDados();


            XmlSerializer serializer = new XmlSerializer(typeof(List<Agencia>));

            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, bunda);
                var teste = Encoding.UTF8.GetString(stream.GetBuffer());
                File.WriteAllText(path, teste);
            }

            string a = File.ReadAllText(path);

            using (var stream = new MemoryStream())
            {
                var bytes = Encoding.UTF8.GetBytes(a);
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                var taaqui = (List<Agencia>)serializer.Deserialize(stream);
            }
        }

        private static void METODO1()
        {
            AgenciaDaoSql sqldao = new AgenciaDaoSql();

            string path = @"C:\Users\marcus.kayser\Desktop\arquivostreinamento\bunda.json";
            List<Agencia> bunda = sqldao.ListaDados();

            string serialize = JsonConvert.SerializeObject(bunda);

            File.WriteAllText(path, serialize);

            string a = File.ReadAllText(path);

            List<Agencia> deserialize = JsonConvert.DeserializeObject<List<Agencia>>(a);
        }
    }
}
