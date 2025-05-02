84;95;113  -  butao

89;98;116  -  texto

108;118;132  -  borda text box



using (var db = new DBContext())
{
    var user = new Utilizador("admin", "admin", CaesarCipher.Encrypt("admin", 10));
    db.Utilizadores.Add(user);
    db.SaveChanges();
}
