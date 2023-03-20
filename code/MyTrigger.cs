using System;
using Editor;
using System.ComponentModel.DataAnnotations;

namespace Sandbox
{

	[HammerEntity]
	[Display( Name = "MyTrigger", GroupName = "Triggers", Description = "This trigger will make you respawn")]
	public partial class MyTrigger : BaseTrigger
	{

		public MyTrigger() { }

		public override void StartTouch( Entity other )
		{
			base.StartTouch( other );

			if ( !Game.IsServer ) return;
			if ( other is not Pawn player ) return;

			Log.Error( player.Client.Name );
			player.Position = Vector3.Zero;
		}
	}
}
