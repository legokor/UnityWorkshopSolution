//Főbb életciklus függvények:
void Awake(){
    //Az első dolog ami lefut, inicializáláshoz használatos
}
void Start() {
    //A játék elindításakor, vagy az új elem létrejöttekor
}
void Update(){
    //Minden képkockán lefut, FPS függő
    Time.deltaTime; //Ez visszaadja az előző képkocka óta eltelt időt
    //Ezzel beszorozva a mozgásokat FPS függetlenné tudjuk tenni
}
void FixedUpdate() {
    //FPS független Update, futási gyakorisága a fizika motorhoz van kötve
    //Másodpercenkénti hívása projekt szinten állítható
    //Főként fizikához szokás használni    
}
void OnDestroy(){
    //Az elem megsemmisülése előtti utolsó lefutó függvény
}

Debug.Log("információ");
Debug.LogWarning("figyelmeztetés");
Debug.LogError("Hiba"); //Ez esetén beállítható, hogy leálljon

//Létrehozás futási időben:
//mit GameObject típusú, általában [SerializeField]-ben kapjuk
//hol egy Vector3 rotation, általában transform.position 
//forgas: egy Quaternion (nem néztük), általában transform.rotation
//Visszaadja GameObject-ként a létrehozott elemet
GameObject uj = Instantiate(mit, hol, forgas);
//Pozíció és forgás elhagyható, ekkor a másolt GameObject helyén hozza létre
GameObject uj = Instantiate(mit);
//Mindkét változatnál megatható, hogy hierarchiában ki legyen felette
GameObject uj = Instantiate(mit, szulo);
