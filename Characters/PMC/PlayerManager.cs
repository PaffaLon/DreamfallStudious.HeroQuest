using System.Diagnostics;

namespace Characters.PMC
{
    public class PlayerManager
    {
        private List<Player> _players = new();       


        /// <summary>
        /// Saves a <see cref="Player"/> object to the manager's collection of player objects.
        /// </summary>
        /// <param name="player"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public void SavePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentNullException();

            if (_players.Any(p => p.ID == player.ID))
                throw new Exception($"Player with ID: {player.ID}, already exsists. {nameof(player)}");

            _players.Add(player);
        }

        // This method may requiers improvment to handle a null value of the parameter accordingly. Usage for a try, catch?
        public Player GetPlayer(Player getPlayer, out long lookUpTimeMs)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            Player foundPlayer = null;
            foreach (var p in _players)
                if (p == getPlayer)
                {
                    foundPlayer = p;
                    break;
                }

            sw.Stop();
            lookUpTimeMs = sw.ElapsedMilliseconds;
            return foundPlayer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns a list of all player objects.</returns>
        public List<Player> GetAllPlayers() { return _players; }

        /// <summary>
        /// Deletes a speceif <see cref="Player"/> object from <see cref="_players"/>.
        /// </summary>
        /// <param name="player"></param>
        public void DeletePlayer(Player player) { _players.Remove(player); }


        /// <summary>
        /// Deletes all <see cref="Player"/> objects from <see cref="_players"/>.
        /// </summary>
        public void DeleteAllPlayers()
        {
            foreach (var p in _players)
                _players.Remove(p);
        }

    }
}
