using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bluemagic.Projectiles
{
	public class PuriumChainsaw : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.name = "Purium Chainsaw";
			projectile.width = 18;
			projectile.height = 18;
			projectile.scale = 1.2f;
			projectile.aiStyle = 20;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
		}
	}
}