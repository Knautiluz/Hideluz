using System.Collections.Generic;
using System.Linq;

namespace HideluzEstacionamentos
{
    public class Administrator : Operator
    {

        public Administrator()
        {

        }
        public bool AddTax(int type, float value)
        {
            var con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(IDTIPOVEICULO) FROM PRECOTARIFA WHERE IDTIPOVEICULO = '{0}'", type), 0))
            {
                if (con.Rows > 0)
                {
                    RegisterTax.Operation = "Já existe uma tarifa cadastrada para esse tipo de veículo!";
                    return false;
                }
                else
                {
                    con.RunQuery(string.Format("INSERT INTO PRECOTARIFA (VALORTARIFA, IDTIPOVEICULO) VALUES ('{0}', '{1}')", value, type), 2);
                    RegisterTax.Operation = "Tarifa cadastrada com sucesso!";
                    return true;
                }
            }
            else
            {
                RegisterTax.Operation = con.Message;
                return false;
            }
        }
        public bool ChangeTax(int type, float value)
        {
            Connection con = new Connection();
            if (con.RunQuery(string.Format("UPDATE PRECOTARIFA SET VALORTARIFA = '{0}', IDTIPOVEICULO = '{1}' WHERE IDTIPOVEICULO = '{1}'", value, type), 3))
            {
                ModifyTax.Operation = "Taxa modificada!";
                return true;
            }
            else
            {
                ModifyTax.Operation = con.Message;
                return false;
            }
        }
        public bool DeleteTax(int type)
        {
            Connection con = new Connection();
            if (con.RunQuery(string.Format("SELECT COUNT(IDTIPOVEICULO) FROM PRECOTARIFA WHERE IDTIPOVEICULO = {0}", type), 0))
            {
                if (con.Rows > 0)
                {
                    if (con.RunQuery(string.Format("DELETE FROM PRECOTARIFA WHERE IDTIPOVEICULO = {0}", type), 4))
                    {
                        RemoveUser.Operation = "A taxa foi removida.";
                        return true;
                    }
                    else
                    {
                        RemoveUser.Operation = con.Message;
                        return false;
                    }
                }
                else
                {
                    RemoveUser.Operation = "Não existe taxa cadastrada para este tipo de veículo.";
                    return false;
                }
            }
            else
            {
                RemoveUser.Operation = con.Message;
                return false;
            }
        }
        public bool AddUser(User user, string operatorId)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(CPF) FROM USUARIO WHERE CPF = '{0}'", user.Document), 0))
            {
                if (con.Rows > 0)
                {
                    RegisterUser.Operation = "O CPF informado já está cadastrado.";
                    return false;
                }
                else
                {
                    con.RunQuery(string.Format("INSERT INTO USUARIO (CPF, NOME, USUARIO, SENHA, STATUS, TIPOUSUARIO) values ('{0}', '{1}', '{2}', '{3}', {4}, {5})", user.Document, user.Name, user.Username, user.Password, 1, user.Type), 2);
                    RegisterUser.Operation = "Usuário cadastrado com sucesso!";
                    return true;
                }
            }
            else
            {
                RegisterUser.Operation = con.Message;
                return false;
            }
        }
        public bool ChangeUser(User user, string doc)
        {
            Connection con = new Connection();
            if (con.RunQuery(string.Format("UPDATE USUARIO SET CPF = '{0}', NOME = '{1}', USUARIO = '{2}', SENHA = '{3}', STATUS = {4}, TIPOUSUARIO = {5} WHERE CPF = '{6}'", user.Document, user.Name, user.Username, user.Password, user.Status, user.Type, doc), 3))
            {
                ModifyUser.Operation = "Veículo atualizado com sucesso!";
                return true;
            }
            else
            {
                ModifyUser.Operation = con.Message;
                return false;
            }
        }
        public Dictionary<string, string> CheckUser(string document)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            if (con.RunQuery(string.Format("SELECT * FROM USUARIO WHERE CPF = '{0}'", document), 1))
            {
                if (con.Rows < 1)
                {
                    SearchUser.Operation = "Não existe usuário cadastrado com o CPF informado.";
                    return results;
                }
                results.Add("CPF", con.Fecth.Values.ElementAt(0));
                results.Add("NOME", con.Fecth.Values.ElementAt(1));
                results.Add("USUARIO", con.Fecth.Values.ElementAt(2));
                results.Add("SENHA", con.Fecth.Values.ElementAt(3));
                results.Add("STATUS", con.Fecth.Values.ElementAt(4));
                results.Add("TIPO", con.Fecth.Values.ElementAt(5));
                return results;
            }
            else
            {
                SearchUser.Operation = con.Message;
                return results;
            }
            
        }
        public bool DeleteUser(string doc)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(CPF) FROM USUARIO WHERE CPF = '{0}'", doc), 0))
            {
                if (con.Rows > 0)
                {
                    if (con.RunQuery(string.Format("DELETE FROM USUARIO WHERE CPF = '{0}'", doc), 4))
                    {
                        RemoveUser.Operation = "O usuário foi apagado.";
                        return true;
                    }
                    else
                    {
                        RemoveUser.Operation = con.Message;
                        return false;
                    }
                }
                else
                {
                    RemoveUser.Operation = "O CPF digitado não foi encontrado.";
                    return false;
                }
            }
            else
            {
                RemoveUser.Operation = con.Message;
                return false;
            }
        }
    }
}
