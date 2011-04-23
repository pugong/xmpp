// Compression.cs
//
//Ubiety XMPP Library Copyright (C) 2006 - 2009 Dieter Lunn
//
//This library is free software; you can redistribute it and/or modify it under
//the terms of the GNU Lesser General Public License as published by the Free
//Software Foundation; either version 3 of the License, or (at your option)
//any later version.
//
//This library is distributed in the hope that it will be useful, but WITHOUT
//ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
//
//You should have received a copy of the GNU Lesser General Public License along
//with this library; if not, write to the Free Software Foundation, Inc., 59
//Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.Xml;
using ubiety.attributes;
using ubiety.common;

namespace ubiety.core.compression
{
	///<summary>
	///</summary>
	[XmppTag("compression", Namespaces.Compression, typeof (Compression))]
	public class Compression : Tag
	{
		///<summary>
		///</summary>
		///<param name="doc"></param>
		public Compression(XmlDocument doc)
			: base("", new XmlQualifiedName("compression", Namespaces.Compression), doc)
		{
		}

		///<summary>
		///</summary>
		public string[] Algorithms
		{
			get
			{
				var nl = GetElementsByTagName("method", Namespaces.Compression);
				var als = new string[nl.Count];
				var i = 0;
				foreach (XmlElement m in nl)
				{
					als[i] = m.InnerText;
					i++;
				}
				return als;
			}
		}
	}
}