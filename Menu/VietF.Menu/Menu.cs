#region Using Statements
using System;
using System.Collections.Generic;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Managers;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
#endregion

namespace VietF.Menu
{
    public class Menu
    {
        private List<Entity> ListIconMenu;
        public Menu(EntityManager entityManager)
        {
            var camera2D = new FixedCamera2D("Camera2D") { ClearFlags = ClearFlags.DepthAndStencil };

            entityManager.Add(camera2D);

            // Draw a simple sprite
            Entity sprite = new Entity()
                .AddComponent(new Transform2D())
                // Change this line for a custom assets "new Sprite("Content/MyTexture"))"
                // Manage assets using the Resources.weproj link to open the Assets Exporter tool.
                .AddComponent(new Sprite(StaticResources.DefaultTexture))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque));

            entityManager.Add(sprite);

        }

    }
}
