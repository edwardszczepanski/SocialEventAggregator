using System;

namespace LaneTransitApp
{
	public class Route
	{
		private String name;
		private String url;
		public Route (String name, String url)
		{
			this.name = name;
			this.url = url;
		}
		public String getRoute(){
			return name;
		}
	}
}

