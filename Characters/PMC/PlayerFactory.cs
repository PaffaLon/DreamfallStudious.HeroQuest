using Characters.PMC;

namespace Characters
{
    /// <summary>
    /// Responsibility: Generating new character objects of spefeic character variation.
    /// </summary>
    public class PlayerFactory
    {
        private const int DEFAULT_HEALTH_CURRENT = 100;
        private const int DEFAULT_HEALTH_MAX = 100;
        private const int DEFAULT_HEALTH_MIN = 0; // Health usually has a min of 0

        private const int DEFAULT_STAMINA_CURRENT = 100;
        private const int DEFAULT_STAMINA_MAX = 100;
        private const int DEFAULT_STAMINA_MIN = 0;
        public Player NewPlayer(string name)
        {
            Player player = new Player(name, DEFAULT_HEALTH_CURRENT, DEFAULT_HEALTH_MAX, DEFAULT_HEALTH_MIN,
                                             DEFAULT_STAMINA_CURRENT, DEFAULT_STAMINA_MAX, DEFAULT_STAMINA_MIN);


            return player;
        }
    }
}
