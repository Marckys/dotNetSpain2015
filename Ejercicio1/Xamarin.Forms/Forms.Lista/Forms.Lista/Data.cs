using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Data
    {
        public static List<Film> GetFilms()
        {
            return new List<Film>
            {
                new Film {Name = "Birdman", Director = "Alejandro G Iñárritu", Description = "Riggan Thomson espera que encabezando una nueva y ambiciosa obra en Broadway va a lograr, entre otras cosas, dar una nueva vida a su moribunda carrera. En muchos sentidos es un iniciativa profundamente insensata, pero el antiguo superhéroe del cine tiene grandes esperanzas de que este ardid creativo le va a legitimar como artista y va a demostrar a todos, incluido él mismo, que es algo más que una vieja gloria de Hollywood.", Picture = ""},
                new Film {Name = "El gran hotel Budapest", Director = " Wes Anderson", Description = "Narra las aventuras de Gustave H., el legendario conserje de un famoso hotel europeo del período de entreguerras, y de Zero Moustafa, un botones que se convierte en su amigo más leal. La historia incluye el robo y la recuperación de una pintura renacentista de incalculable valor, una frenética batalla por una inmensa fortuna familiar y el inicio de la más dulce historia de amor. Como telón de fondo, un continente que está sufriendo una rápida y drástica transformación.", Picture = ""},
                new Film {Name = "The imitation game", Director = "Morten Tyldum", Description = "Durante el invierno de 1952, las autoridades británicas entraron en el hogar del matemático, analista y héroe de guerra Alan Turing con la intención de investigar la denuncia de un robo. Acabaron arrestando a Turing acusándole de una indecencia grave, un cargo que le supondría una devastadora condena por lo que en aquel entonces se consideraba una ofensa criminal: ser homosexual. Los oficiales no tenían ni idea de que en realidad estaban incriminando al pionero de la informática actual.", Picture = ""},
                new Film {Name = "Boyhood", Director = "Richard Linklater", Description = "La película sigue a Mason desde los 6 años durante algo más de una década poblada de cambios, mudanzas y controversias, relaciones que se tambalean, bodas, diferentes colegios, primeros amores, primeras desilusiones, momentos maravillosos, momentos de miedo y una constante mezcla de desgarro y de sorpresa. Los resultados son totalmente impredecibles, ya que cada momento lleva a otro, uniéndose en la profunda experiencia personal que nos forma mientras crecemos y nos acoplamos a la siempre cambiante naturaleza de nuestra vida.", Picture = ""},
                new Film {Name = "El francotirador", Director = "Clint Eastwood", Description = "Adaptación a la gran pantalla de la autobiografía del Navy SEAL Chris Kyle, un tejano con el récord de muertes como francotirador del ejército norteamericano", Picture = ""},
                new Film {Name = "La teoría del todo", Director = "James Marsh", Description = "En 1963, Stephen estudia Cosmología en la famosa Universidad de Cambridge y está decidido a encontrar una explicación sencilla y elocuente del origen del universo. Su mundo se abre de golpe cuando se enamora perdidamente de Jane Wilde, una alumna de la Facultad de Arte de Cambridge. Sin embargo, poco después de cumplir 21 años, recibe un terrible mazazo: le diagnostican un trastorno de la neurona motora que va a atacar sus piernas y brazos, y que va a afectar también a sus sentidos, lo que va a limitar su capacidad de hablar y moverse. Y peor aún, le dan dos años de vida.", Picture = ""},
                new Film {Name = "Selma", Director = "Ava DuVernay", Description = "En la segunda mitad del siglo XX, en Alabama empezó la marcha que emprendió el líder negro Martin Luther King en defensa de los derechos civiles.", Picture = ""},
            };
        } 
    }

    public class Film
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}
