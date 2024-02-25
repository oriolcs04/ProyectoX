using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using Unity.VisualScripting.Dependencies.Sqlite;
using System.Data.Common;

public class BBDD : MonoBehaviour
{
    public List<AlimentoSO> alimentos = new();
    public List<PlanetaSO> planetas = new();
    public List<ElementoSO> elementos = new();
    public List<AlienSO> aliens = new();

    // Start is called before the first frame update
    void Start()
    {
        CreateAndOpenDatabase();

        
    }

    private IDbConnection CreateAndOpenDatabase()
    {
        // Open a connection to the database.
        string dbUri = "URI=file:MyDatabase.sqlite";
        IDbConnection dbConnection = new SqliteConnection(dbUri);
        dbConnection.Open();
        
        // Create a table for the hit count in the database if it does not exist yet.
        IDbCommand dbCommandCreateTable = dbConnection.CreateCommand();
        dbCommandCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS ALIMENTS (id_alim INT NOT NULL, nom_alim VARCHAR(40) NOT NULL, desc_alim VARCHAR(500) NOT NULL, PRIMARY KEY (id_alim));" +
                                            "CREATE TABLE IF NOT EXISTS PLANETA (id_planeta INT NOT NULL, nom_planeta VARCHAR(40) NOT NULL, desc_planeta VARCHAR(500) NOT NULL, PRIMARY KEY (id_planeta));" +
                                            "CREATE TABLE IF NOT EXISTS Element (id_elem INT NOT NULL, nom_elem VARCHAR(40) NOT NULL, desc_elem VARCHAR(500) NOT NULL, PRIMARY KEY (id_elem));" +
                                            "CREATE TABLE IF NOT EXISTS ALIEN (id_alien INT NOT NULL, id_alim INT NOT NULL, id_planeta INT NOT NULL, id_elem INT NOT NULL, nom_alien VARCHAR(40) NOT NULL, desc_alien VARCHAR(500) NOT NULL, PRIMARY KEY (id_alien, id_alim, id_planeta, id_elem), FOREIGN KEY (id_alim) REFERENCES Aliments (id_alim), FOREIGN KEY (id_planeta) REFERENCES planeta (id_planeta), FOREIGN KEY (id_elem) REFERENCES Element (id_elem) );"; // 7
        dbCommandCreateTable.ExecuteReader();

        // Insert hits into the table.
        IDbCommand dbCommandInsertValue = dbConnection.CreateCommand();
        dbCommandInsertValue.CommandText = "Insert or replace into Element(id_elem, nom_elem, desc_elem) Values ( 1, 'Metal Antiguo', 'El Elemento Metál Antiguo es un metal legendario, con una apariencia resplandeciente y una historia enraizada en las épocas ancestrales el cual guarda un gran poder.');" +
                                            "Insert or replace into Element(id_elem, nom_elem, desc_elem) Values ( 2, 'Hierro', 'En cualquier momento puede convertir su cuerpo en hierro, siendo como un escudo ante el enemigo, tambien se puede disolver convirtiendose en un elemento liquido. Tiene el poder magentico muy fuerte en el que puede atraer estrellas entre otras cosas.');" +
                                            "Insert or replace into Element(id_elem, nom_elem, desc_elem) Values ( 3, 'Magnetite', 'Este elemento tiene propidades magneticas extraodinarias que concede al portador el poder de manipular los campos magneticos.');" +
                                            "Insert or replace into Element(id_elem, nom_elem, desc_elem) Values ( 4, 'Flexiacero', 'Los Mekkari están forjados con Flexiacero, un prodigio de la metalurgia cuyas propiedades desafían los métodos convencionales de fabricación. Esta variante de acero posee la sorprendente capacidad de doblarse sin romperse, mientras mantiene una ligereza equiparable a la del plástico. Este material impregna la mayoría de los cuerpos de los Mekkari, otorgándoles una combinación única de resistencia y flexibilidad que les permite mantenerse en funcionamiento incluso en ambientes hostiles.');" +
                                            "Insert or replace into PLANETA(id_planeta, nom_planeta, desc_planeta) Values ( 1, 'Metalloria', 'Metalloria, un mundo donde las ruinas antiguas susurran historias de una tecnología perdida. Sus paisajes están salpicados de artefactos de metal oxidado y estructuras monumentales que evocan un pasado de grandeza tecnológica.');" +
                                            "Insert or replace into PLANETA(id_planeta, nom_planeta, desc_planeta) Values ( 2, 'Mun', 'Una Luna con unas grandes cantidades de agua que abarcan gran parte del terreno generando un habitat marino.');" +
                                            "Insert or replace into PLANETA(id_planeta, nom_planeta, desc_planeta) Values ( 3, 'Scrapton', 'Scrapton, es un mundo cubierto de interminables desiertos de arena rojiza y montañas de arena enormes. El planeta esta plagado por piezas metalicas oxidadas provenientes a antiguas civilizaciones y naves perdidas por el espacio.');" +
                                            "Insert or replace into PLANETA(id_planeta, nom_planeta, desc_planeta) Values ( 4, 'Geonova', 'En un mundo rebosante de minerales preciosos y metales que parecen haber sido creados gracias a una metalurgia muy avanzada, los Mekkari emergieron como el legado de una antigua civilización que se desvaneció en el olvido sin dejar rastro alguno. A día de hoy, continúan cumpliendo fielmente las últimas órdenes de sus misteriosos predecesores: la extracción incesante de recursos.');" +
                                            "Insert or replace into Aliments(id_alim, nom_alim, desc_alim) Values ( 1, 'Metales', 'La comida metálica: un festín futurista donde los sabores resuenan con la intensidad del acero recién forjado. Texturas crujientes y sabores audaces evocan la esencia del metal fundido.');" +
                                            "Insert or replace into Aliments(id_alim, nom_alim, desc_alim) Values ( 2, 'Crustac y hierro', 'Es un alienigena diminuto que siempre esta cerca de las estrellas y flores. Es conocido por ser una mutación de los crustáceos. Su habitad que es un pedazo de Luna contiene hierro, que es uno de sus alimentos.');" +
                                            "Insert or replace into Aliments(id_alim, nom_alim, desc_alim) Values ( 3, 'Aceite y oxido', 'Un alimento poco comun que se extrae de minerales y metales, cuando tiene mas oxido mas bueno es.');" +
                                            "Insert or replace into Aliments(id_alim, nom_alim, desc_alim) Values ( 4, 'Electricidad', 'La fuente de energía de los Mekkari en el espacio es un enigma rodeado de teorías especulativas. Entre ellas, destaca la sugerencia de una entidad conocida como la Reina, que se postula como la generadora de energía a partir de minerales obtenidos durante la colonización de asteroides y planetas. Aunque escasas pruebas respaldan esta teoría, lo único cierto es la necesidad imperiosa de electricidad para su funcionamiento.');" +
                                            "Insert or replace into ALIEN(id_alien, id_alim, id_planeta, id_elem, nom_alien, desc_alien)  Values ( 1, 1, 1, 1, 'Tekni', 'El Alien Lila emerge del universo con su piel resplandeciente de tonos violetas, envuelto en un mecha imponente y elegante. Su presencia en el campo de batalla es una danza cósmica, fusionando la gracia alienígena con la tecnología más avanzada.');" +
                                            "Insert or replace into ALIEN(id_alien, id_alim, id_planeta, id_elem, nom_alien, desc_alien)  Values ( 2, 2, 2, 2, 'Equus', 'Alien que proviene de las aguas de la luna.');" +
                                            "Insert or replace into ALIEN(id_alien, id_alim, id_planeta, id_elem, nom_alien, desc_alien)  Values ( 3, 3, 3, 3, 'Scavenger', 'Es un alienigena con una apariencia desconocida que siempre va con una tunica y una mascara que ocultan su cara. Este se dedica a acumular chatarra y crean sus hogares con ella. Son lo suficiente inteligentes para constuir armas y herramientas.');" +
                                            "Insert or replace into ALIEN(id_alien, id_alim, id_planeta, id_elem, nom_alien, desc_alien)  Values ( 4, 4, 4, 4, 'Mekkari', 'Una raza alienígena similar a las Formicidae de la Tierra, posee características humanoides pero carece de conciencia individualista; en su lugar, todos los individuos comparten una conciencia colectiva, formando una colonia que piensa y actúa como un único ente.')"; //; 10
        dbCommandInsertValue.ExecuteNonQuery();

        SelectAlimentos(dbConnection);
        SelectPlanetas(dbConnection);
        SelectElementos(dbConnection);
        SelectAliens(dbConnection);

        return dbConnection;
    }

    private void SelectAliens(IDbConnection dbConnection)
    {
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand();
        dbCommandReadValues.CommandText = "SELECT * FROM ALIEN";
        IDataReader dataReader = dbCommandReadValues.ExecuteReader();


        while (dataReader.Read())
        {
            aliens.Add(new AlienSO(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetString(4), dataReader.GetString(5)));
        }

        //foreach (var item in aliens)
        //{
        //    Debug.Log(item.alienId); 
        //    Debug.Log(item.alienName);
        //    Debug.Log(item.alienDescription);
        //    Debug.Log(item.alienIdAlimento);
        //    Debug.Log(item.alienIdPlaneta);
        //    Debug.Log(item.alienIdElemento);
        //}
    }

    private void SelectAlimentos(IDbConnection dbConnection)
    {
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand();
        dbCommandReadValues.CommandText = "SELECT * FROM Aliments";
        IDataReader dataReader = dbCommandReadValues.ExecuteReader();

        while (dataReader.Read())
        {
            alimentos.Add(new AlimentoSO(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
        }

        //foreach (var item in alimentos)
        //{
        //    Debug.Log(item.alimentoId);
        //    Debug.Log(item.alimentoName);
        //    Debug.Log(item.alimentoDescription);
        //}
    }

    private void SelectPlanetas(IDbConnection dbConnection)
    {
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand(); 
        dbCommandReadValues.CommandText = "SELECT * FROM PLANETA"; 
        IDataReader dataReader = dbCommandReadValues.ExecuteReader(); 

        while (dataReader.Read())
        {
            planetas.Add(new PlanetaSO(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
        }

        //foreach (var item in planetas)
        //{
        //    Debug.Log(item.planetaId);
        //    Debug.Log(item.planetaName);
        //    Debug.Log(item.planetaDescription);
        //}
    }

    private void SelectElementos(IDbConnection dbConnection)
    {
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand();
        dbCommandReadValues.CommandText = "SELECT * FROM Element";
        IDataReader dataReader = dbCommandReadValues.ExecuteReader();

        while (dataReader.Read())
        {
            elementos.Add(new ElementoSO(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
        }

        //foreach (var item in elementos)
        //{
        //    Debug.Log(item.elementoId);
        //    Debug.Log(item.elementoName);
        //    Debug.Log(item.elementoDescription);
        //}
    }
}
