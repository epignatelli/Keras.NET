/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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

using Keras.Models;
using Numpy;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Keras.Applications.MobileNet
{
    /// <summary>
    /// MobileNet model, with weights pre-trained on ImageNet.
    /// Note that this model only supports the data format 'channels_last' (height, width, channels).
    /// The default input size for this model is 224x224.
    /// </summary>
    /// <seealso cref="Keras.Applications.AppModelBase" />
    public class MobileNetV1 : AppModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNetV1"/> class.
        /// </summary>
        public MobileNetV1()
            : base((PyObject)Keras.keras.applications.mobilenet)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNetV1" /> class.
        /// </summary>
        /// <param name="input_shape">optional shape tuple, only to be specified if include_top is False (otherwise the input shape has to be (224, 224, 3) (with 'channels_last' data format) or (3, 224, 224) (with 'channels_first' data format). It should have exactly 3 inputs channels, and width and height should be no smaller than 32. E.g. (200, 200, 3) would be one valid value.</param>
        /// <param name="alpha">controls the width of the network. If alpha &lt; 1.0, proportionally decreases the number of filters in each layer. If alpha &gt; 1.0, proportionally increases the number of filters in each layer.</param>
        /// <param name="depth_multiplier">depth multiplier for depthwise convolution (also called the resolution multiplier)</param>
        /// <param name="dropout">The dropout rate.</param>
        /// <param name="include_top">optional shape tuple, only to be specified if include_top is False (otherwise the input shape has to be (224, 224, 3) (with 'channels_last' data format) or (3, 224, 224) (with 'channels_first' data format) for NASNetMobile or (331, 331, 3) (with 'channels_last' data format) or (3, 331, 331) (with 'channels_first' data format) for NASNetLarge. It should have exactly 3 inputs channels, and width and height should be no smaller than 32. E.g. (200, 200, 3) would be one valid value.</param>
        /// <param name="weights">one of None (random initialization), 'imagenet' (pre-training on ImageNet), or the path to the weights file to be loaded.</param>
        /// <param name="input_tensor">optional Keras tensor (i.e. output of layers.Input()) to use as image input for the model.</param>
        /// <param name="pooling">optional pooling mode for feature extraction when include_top is False.
        /// None means that the output of the model will be the 4D tensor output of the last convolutional layer.
        /// avg means that global average pooling will be applied to the output of the last convolutional layer, and thus the output of the model will be a 2D tensor.
        /// max means that global max pooling will be applied.</param>
        /// <param name="classes">optional number of classes to classify images into, only to be specified if include_top is True, and if no weights argument is specified.</param>
        public MobileNetV1(Shape input_shape = null, float alpha = 1, int depth_multiplier = 1, float dropout = 1e-3f, bool include_top = true, string weights = "imagenet",
                                    NDarray input_tensor = null, string pooling = "None", int classes = 1000)
            : this()
        {
            Parameters["input_shape"] = input_shape;
            Parameters["alpha"] = alpha;
            Parameters["depth_multiplier"] = depth_multiplier;
            Parameters["dropout"] = dropout;
            Parameters["include_top"] = include_top;
            Parameters["weights"] = weights;
            Parameters["input_tensor"] = input_tensor;
            Parameters["pooling"] = pooling;
            Parameters["classes"] = classes;
            PyInstance = caller.MobileNet;
            Init();
        }
    }

    /// <summary>
    /// MobileNet model, with weights pre-trained on ImageNet.
    /// Note that this model only supports the data format 'channels_last' (height, width, channels).
    /// The default input size for this model is 224x224.
    /// </summary>
    /// <seealso cref="Keras.Applications.AppModelBase" />
    public class MobileNetV2 : AppModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNetV2"/> class.
        /// </summary>
        public MobileNetV2()
            : base((PyObject)Keras.keras.applications.mobilenet_v2)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNetV2" /> class.
        /// </summary>
        /// <param name="input_shape">optional shape tuple, only to be specified if include_top is False (otherwise the input shape has to be (224, 224, 3) (with 'channels_last' data format) or (3, 224, 224) (with 'channels_first' data format). It should have exactly 3 inputs channels, and width and height should be no smaller than 32. E.g. (200, 200, 3) would be one valid value.</param>
        /// <param name="alpha">controls the width of the network. If alpha &lt; 1.0, proportionally decreases the number of filters in each layer. If alpha &gt; 1.0, proportionally increases the number of filters in each layer.</param>
        /// <param name="depth_multiplier">depth multiplier for depthwise convolution (also called the resolution multiplier)</param>
        /// <param name="dropout">The dropout rate.</param>
        /// <param name="include_top">optional shape tuple, only to be specified if include_top is False (otherwise the input shape has to be (224, 224, 3) (with 'channels_last' data format) or (3, 224, 224) (with 'channels_first' data format) for NASNetMobile or (331, 331, 3) (with 'channels_last' data format) or (3, 331, 331) (with 'channels_first' data format) for NASNetLarge. It should have exactly 3 inputs channels, and width and height should be no smaller than 32. E.g. (200, 200, 3) would be one valid value.</param>
        /// <param name="weights">one of None (random initialization), 'imagenet' (pre-training on ImageNet), or the path to the weights file to be loaded.</param>
        /// <param name="input_tensor">optional Keras tensor (i.e. output of layers.Input()) to use as image input for the model.</param>
        /// <param name="pooling">optional pooling mode for feature extraction when include_top is False.
        /// None means that the output of the model will be the 4D tensor output of the last convolutional layer.
        /// avg means that global average pooling will be applied to the output of the last convolutional layer, and thus the output of the model will be a 2D tensor.
        /// max means that global max pooling will be applied.</param>
        /// <param name="classes">optional number of classes to classify images into, only to be specified if include_top is True, and if no weights argument is specified.</param>
        public MobileNetV2(Shape input_shape = null, float alpha = 1, int depth_multiplier = 1, float dropout = 1e-3f, bool include_top = true, string weights = "imagenet",
                                    NDarray input_tensor = null, string pooling = "None", int classes = 1000)
            : this()
        {
            Parameters["input_shape"] = input_shape;
            Parameters["alpha"] = alpha;
            Parameters["depth_multiplier"] = depth_multiplier;
            Parameters["dropout"] = dropout;
            Parameters["include_top"] = include_top;
            Parameters["weights"] = weights;
            Parameters["input_tensor"] = input_tensor;
            Parameters["pooling"] = pooling;
            Parameters["classes"] = classes;
            PyInstance = caller.MobileNetV2;
            Init();
        }
    }
}

