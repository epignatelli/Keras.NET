/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Keras
{
    /// <summary>
    /// String or instance of a class
    /// </summary>
    public class StringOrInstance
    {
        /// <summary>
        /// The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOrInstance"/> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public StringOrInstance(PyObject obj)
        {
            PyObject = obj;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="StringOrInstance"/>.
        /// </summary>
        /// <param name="opt">The opt.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator StringOrInstance(string opt)
        {
            return new StringOrInstance(opt.ToPython());
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Base"/> to <see cref="StringOrInstance"/>.
        /// </summary>
        /// <param name="opt">The opt.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator StringOrInstance(Base opt)
        {
            return new StringOrInstance(opt.PyInstance);
        }
    }

    public class KerasFunction
    {
        /// <summary>
        /// The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOrInstance"/> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public KerasFunction(PyObject obj)
        {
            PyObject = obj;
        }
    }

    public class KerasIterator : object
    {
        /// <summary>
        /// The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOrInstance"/> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public KerasIterator(PyObject obj)
        {
            PyObject = obj;
        }
    }

    public class DirectoryIterator : object
    {
        /// <summary>
        /// The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOrInstance"/> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public DirectoryIterator(PyObject obj)
        {
            PyObject = obj;
        }
    }
}
