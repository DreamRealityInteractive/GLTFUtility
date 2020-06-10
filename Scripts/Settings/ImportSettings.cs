using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Siccity.GLTFUtility {
	[Serializable]
	public class ImportSettings {
        public ImportSettings()
        {
            shaderOverrides = new ShaderSettings();
        }
        public ImportSettings(Shader defaultShader)
        {
            shaderOverrides = new ShaderSettings(defaultShader);
        }

        public ImportSettings(Material _overrideMaterial)
        {
            overrideMaterial = _overrideMaterial;
        }

        public bool materials = true;
        [FormerlySerializedAs("shaders")]
        public ShaderSettings shaderOverrides;
		public bool useLegacyClips;

		[Tooltip("Interpolation mode applied to all keyframe tangents. Use Import From File when mixing modes within an animation.")]
		public InterpolationMode interpolationMode = InterpolationMode.ImportFromFile;
	}
}