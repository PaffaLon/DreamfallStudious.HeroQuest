using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using Characters.PMC;
using Characters;



namespace CharacterTesting
{
    public class PlayerCharacterCreationTests
    {
        private PlayerFactory playerFactory = new();
        
        // Helper method to create a default player for tests
        private Player CreateDefaultPlayer(string name = "Test Player")
        { return playerFactory.NewPlayer(name); }
        
        
        [Fact]
        public void SavePlayer_AddPlayerToManager()
        {
            // Arrange
            var manager = new PlayerManager();
            var player = CreateDefaultPlayer();

            // Act
            manager.SavePlayer(player);

            // Assert
            Assert.Single(manager.GetAllPlayers());           // Check if only one player is in the list
            Assert.Contains(player, manager.GetAllPlayers()); // Check if the specific player is in the list
        }

        [Fact]
        public void SavePlayer_ThrowsException_WhenPlayerIsNull()
        {
            // Arrange
            var manager = new PlayerManager();

            // Act & Assert
            var ex = Assert.Throws<ArgumentNullException>(() => manager.SavePlayer(null));
                     Assert.Contains("Player object can't be null.", ex.Message);
        }

        public void SavePlayer_ThrowsException_WhenPlayerWithSameIDAlreadyExsists()
        {
            // Arrange
            // Act
            // Assert
        }

        public void GetPlayerbyID_ReturnCorrectPlayer_WhenFound()
        {
            // Arrange
            var manager = new PlayerManager();
            var p1 = CreateDefaultPlayer("Player A");
            var p2 = CreateDefaultPlayer("Player B");
            var p3 = CreateDefaultPlayer("Player C");
            var p4 = CreateDefaultPlayer("Player D");

            manager.SavePlayer(p1);
            manager.SavePlayer(p2);
            manager.SavePlayer(p3);
            manager.SavePlayer(p4);

            // Act
            long lookUpTime;
            Player foundPlayer = manager.GetPlayer(p2.ID, out lookUpTime);

            // Assert
            Assert.NotNull(foundPlayer);
            Assert.Equal(p2.ID, foundPlayer.ID); // Check if it's the correct player by ID.
            Assert.Equal(p2.Name, foundPlayer.Name);
            Assert.True(lookUpTime >= 0); // Check that lookup time is measured.
        }
    }
}