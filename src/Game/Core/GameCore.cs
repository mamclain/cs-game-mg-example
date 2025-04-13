using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game.Core;

/// <summary>
///     Represents the core class of the game, inheriting from the Microsoft.Xna.Framework.Game framework.
///     This class handles the game lifecycle, including initialization, content loading, updating, and rendering.
/// </summary>
public class GameCore : Microsoft.Xna.Framework.Game
{
    /// <summary>
    ///     Represents an instance of the GraphicsDeviceManager used to manage graphics settings and device creation
    ///     in the game. It is responsible for configuring and controlling the graphics rendering functionality,
    ///     including resolution, display orientation, and other graphical properties.
    /// </summary>
    private GraphicsDeviceManager _graphics;

    /// <summary>
    ///     Handles batch processing and rendering of 2D sprites for the game.
    ///     Manages efficient rendering by minimizing state changes, allowing multiple
    ///     sprites to be drawn with a single call to the GPU.
    /// </summary>
    private SpriteBatch _spriteBatch;


    /// <summary>
    ///     Represents the main class for the game that inherits from the Microsoft.Xna.Framework.Game class.
    ///     Manages the game lifecycle including initialization, content loading, updating, and drawing.
    /// </summary>
    public GameCore()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    /// <summary>
    ///     Initializes the game and its required components. This method is executed as part of the game lifecycle,
    ///     allowing any necessary setup to occur before the game is run. Typically used for setting up non-graphics resources
    ///     or initializing game state.
    /// </summary>
    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        base.Initialize();
    }

    /// <summary>
    ///     Loads the necessary game content such as textures, sounds, and other resources.
    ///     This method is executed during the content loading phase of the game lifecycle.
    /// </summary>
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    // TODO: use this.Content to load your game content here
    /// <summary>
    ///     Updates the game state based on the game time. Handles user input, game logic, and other updates that need to
    ///     occur in each frame.
    /// </summary>
    /// <param name="gameTime">
    ///     Provides a snapshot of the game's timing values, such as elapsed game time and total
    ///     game time.
    /// </param>
    protected override void Update(GameTime gameTime)
    {
        if (
            GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape)
        )
        {
            Exit();
        }

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    /// <summary>
    ///     Renders the game components to the screen. This method is called during the game's draw phase
    ///     and handles all rendering logic, including clearing the screen and drawing sprites or other objects.
    /// </summary>
    /// <param name="gameTime">
    ///     Provides a snapshot of the game's timing values, such as elapsed game time and total
    ///     game time.
    /// </param>
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
