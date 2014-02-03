/*
 * Copyright 2009-14 Simon J. Williams.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * http://www.kajabity.com
 */

using System;

namespace Kajabity.Tools.Csv
{
	/// <summary>
	/// An exception thrown by <see cref="CsvReader"/> when parsing
	/// a CSV stream.
	/// </summary>
	public class CsvParseException : System.Exception
	{
		/// <summary>
		/// Construct an exception with an error message.
		/// </summary>
		/// <param name="message">A descriptive message for the exception</param>
		public CsvParseException( string message ) : base( message )
		{
		}
	}
}