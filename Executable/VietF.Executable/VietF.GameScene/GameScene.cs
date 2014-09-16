#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Framework;
using WaveEngine.Framework.Services;
#endregion

namespace VietF.GameScene
{
    public class GameScene: Scene
    {
        protected override void Start()
        {
            base.Start();
        }

        protected override void CreateScene()
        {
            if (WaveServices.ScreenContextManager.CurrentContext.Name == "FromMultiplayer")
            { 
                
            }
        }
    }
}
