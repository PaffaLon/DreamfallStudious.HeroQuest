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
        // Helper method to create a default player for tests
        private Player CreateDefaultPlayer(string name = "Test Player")
        { return PlayerFactory.NewPlayer(name); }
        
        
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
    }
}