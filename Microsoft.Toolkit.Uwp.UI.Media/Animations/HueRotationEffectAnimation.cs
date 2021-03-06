// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Uwp.UI.Media;

namespace Microsoft.Toolkit.Uwp.UI.Animations
{
    /// <summary>
    /// An effect animation that targets <see cref="HueRotationEffect.Angle"/>.
    /// </summary>
    public sealed class HueRotationEffectAnimation : EffectAnimation<HueRotationEffect, double?, double>
    {
        /// <inheritdoc/>
        protected override string ExplicitTarget => Target.Id;

        /// <inheritdoc/>
        protected override (double?, double?) GetParsedValues()
        {
            return (To, From);
        }
    }
}
