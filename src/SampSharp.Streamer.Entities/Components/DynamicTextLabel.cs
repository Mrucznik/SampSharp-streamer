﻿// SampSharp.Streamer
// Copyright 2020 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace SampSharp.Streamer.Entities
{
    /// <summary>
    /// Represents a component which provides the data and functionality of an dynamic text label.
    /// </summary>
    public sealed class DynamicTextLabel : Component
    {
        private DynamicTextLabel(Vector3 position)
        {
            Position = position;
        }

        /// <summary>
        /// Gets whether this dynamic text label is valid.
        /// </summary>
        public bool IsValid => GetComponent<NativeDynamicTextLabel>().IsValidDynamic3DTextLabel();

        /// <summary>
        /// Gets the position of this text label.
        /// </summary>
        public Vector3 Position { get; }

        /// <inheritdoc />
        protected override void OnDestroyComponent()
        {
            GetComponent<NativeDynamicTextLabel>().DestroyDynamic3DTextLabel();
        }
    }
}