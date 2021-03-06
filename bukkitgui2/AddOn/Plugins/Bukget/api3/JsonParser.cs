﻿// JsonParser.cs in bukkitgui2/bukkitgui2
// Created 2014/05/03
// 
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file,
// you can obtain one at http://mozilla.org/MPL/2.0/.
// 
// ©Bertware, visit http://bertware.net

using System;
using System.Collections.Generic;
using Jayrock.Json;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Bukget.api3
{
	public static class JsonParser
	{
		/// <summary>
		///     Parse a JsonArray to a list of strings
		/// </summary>
		/// <param name="jsonArray">the Json to convert</param>
		/// <returns> The strings contained in the Json array</returns>
		/// <remarks>
		///     This code should always be able to handle any unexpected input or value, since the input will be coming from
		///     a web resource that might change over time
		/// </remarks>
		public static List<String> ParseJsonStringList(object jsonArray)
		{
			// list with result
			List<String> result = new List<string>();

			if (jsonArray == null)
			{
				return result;
			}

			// convert the object
			JsonArray array = (JsonArray) jsonArray;

			// If no entries, return
			if (array.Length < 1)
			{
				return result;
			}

			for (byte i = 0; i <= array.Length - 1; i++)
			{
				String value = array.GetString(i);
				// make sure there is a value in the string
				if (String.IsNullOrEmpty(value))
				{
					continue;
				}
				// check if it's already added
				if (result.Contains(value))
				{
					continue;
				}
				// if not, add
				result.Add(value);
			}

			return result;
		}

		/// <summary>
		///     Parse a JsonArray to a list of Json objects
		/// </summary>
		/// <param name="jsonArray">the Json to convert</param>
		/// <returns> The Json objects contained in the Json array</returns>
		/// <remarks>
		///     This code should always be able to handle any unexpected input or value, since the input will be coming from
		///     a web resource that might change over time
		/// </remarks>
		public static IEnumerable<JsonObject> ParseJsonObjectList(object jsonArray)
		{
			// list with result
			List<JsonObject> result = new List<JsonObject>();

			if (jsonArray == null)
			{
				return result;
			}

			// convert the object
			JsonArray array = (JsonArray) jsonArray;

			// If no entries, return
			if (array.Length < 1)
			{
				return result;
			}

			for (byte i = 0; i <= array.Length - 1; i++)
			{
				JsonObject value = array.GetObject(i);
				// make sure there is a value in the string
				if (value == null)
				{
					continue;
				}
				// check if it's already added
				if (result.Contains(value))
				{
					continue;
				}
				// if not, add
				result.Add(value);
			}

			return result;
		}
	}
}