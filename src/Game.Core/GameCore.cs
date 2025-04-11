using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game.Core;

public class GameCore : Microsoft.Xna.Framework.Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    /// <summary>
    /// Represents the main class for the game that inherits from the Microsoft.Xna.Framework.Game class.
    /// Manages the game lifecycle including initialization, content loading, updating, and drawing.
    /// </summary>
    public GameCore()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    /// <summary>
    /// Loads the necessary game content such as textures, sounds, and other resources.
    /// This method is executed during the content loading phase of the game lifecycle.
    /// </summary>
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    /// <summary>
    /// Updates the game state based on the game time. Handles user input, game logic, and other updates that need to
    /// occur in each frame.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of the game's timing values, such as elapsed game time and total
    /// game time.</param>
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}