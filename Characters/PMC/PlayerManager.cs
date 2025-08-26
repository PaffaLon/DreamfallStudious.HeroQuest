using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Characters.PMC
{
    public class PlayerManager
    {
        private readonly List<Player> _players = new();       


        /// <summary>
        /// Saves a <see cref="Player"/> object to the manager's collection of player objects.
        /// </summary>
        /// <param name="player"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public void SavePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentNullException($"{nameof(player)}: Can't be null.");

            if (_players.Any(p => p.ID == player.ID))
                throw new InvalidOperationException($"Player with ID: {player.ID}, already exsists. {nameof(player)}");

            _players.Add(player);
        }

        /// <summary>
        /// Retrieves a specific <see cref="Player"/> object by its unique ID.
        /// </summary>
        /// <param name="playerId">The unique ID of the player to retrieve.</param>
        /// <param name="lookUpTimeMs">Outputs the time taken for the lookup in milliseconds.</param>
        /// <returns>The found Player object, or null if not found.</returns>
        public Player? GetPlayer(Guid playerID, out long lookUpTimeMs)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            // Using LINQ's FirstOrDefault is concise and efficient for finding by ID
            Player? foundPlayer = _players.FirstOrDefault(p => p.ID == playerID);

            sw.Stop();
            lookUpTimeMs = sw.ElapsedMilliseconds;


            // Can be null. Handle exeption when returned to caller.
            return foundPlayer;
        }

        /// <summary>
        /// Returns a list of all player objects managed.
        /// </summary>
        /// <remarks>
        /// Consider returning an IReadOnlyList<Player> or a new List<Player>
        /// if you want to prevent external modification of the internal list.
        /// For test purposes, returning the internal list is acceptable.
        /// </remarks>
        public List<Player> GetAllPlayers() { return _players; }

        /// <summary>
        /// Deletes a specific <see cref="Player"/> object from the manager.
        /// </summary>
        /// <param name="player">The player object to delete.</param>
        /// <returns>True if the player was found and removed, false otherwise.</returns>
        public void DeletePlayer(Player player) { _players.Remove(player); }
        public void DeletePlayer(Guid id) 
        { 
            foreach (Player player in _players)
                if(player.ID == id)
                    _players.Remove(player);
        }


        /// <summary>
        /// Deletes all <see cref="Player"/> objects from the <see cref="_players"/>.
        /// </summary>
        public void DeleteAllPlayers()
        {
            foreach (var p in _players)
                _players.Clear();
        }

    }
}
