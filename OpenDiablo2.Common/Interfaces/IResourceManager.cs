﻿using OpenDiablo2.Common.Models;

namespace OpenDiablo2.Common.Interfaces
{
    /// <summary>
    /// A utility class to make it easy to get specific types of resources from the data files in the game.
    /// </summary>
    public interface IResourceManager
    {
        /// <summary>
        /// Get an <see cref="ImageSet" /> from the game's resources.
        /// </summary>
        /// <param name="resourcePath">The path to the ImageSet to grab.</param>
        /// <returns>The <see cref="ImageSet"/> that was requested. Throw an exception if not found.</returns>
        ImageSet GetImageSet(string resourcePath);
        MPQFont GetMPQFont(string resourcePath);
        MPQDS1 GetMPQDS1(string resourcePath, LevelPreset level, LevelDetail levelDetail, LevelType levelType);
        MPQDT1 GetMPQDT1(string resourcePath);
        Palette GetPalette(string paletteName);
    }
}
