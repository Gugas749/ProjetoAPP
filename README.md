---------------------------------------------------------------------------------------------------
FORMS FEITOS

frmLogin

frmGereTipoTarefas

frmDetalhesTarefa (adicionar)

frmDetalhesTarefa (detalhes) ?feito? (por testar)

---------------------------------------------------------------------------------------------------
DESIGN

84;95;113  -  butao

89;98;116  -  texto

108;118;132  -  borda text box

---------------------------------------------------------------------------------------------------
CODIGOS

using (var db = new DBContext())
{
    var user = new Utilizador("admin", "admin", CaesarCipher.Encrypt("admin", 10));
    db.Utilizadores.Add(user);
    db.SaveChanges();
}

---------------------------------------------------------------------------------------------------
JIRA JIRA

https://piogo10.atlassian.net/jira/software/projects/MS3C/summary

---------------------------------------------------------------------------------------------------
LOGINS

gestor1
123

programador1
123

---------------------------------------------------------------------------------------------------
CONTROLADORES

INSERT

UPDATE

DELETE

---------------------------------------------------------------------------------------------------
USER ROLES

1 - Programador

2 - Gestor