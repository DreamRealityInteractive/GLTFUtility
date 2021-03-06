﻿using System;
using UnityEngine;

namespace Siccity.GLTFUtility {
	/// <summary> Defines which shaders to use in the gltf import process </summary>
	[Serializable]
	public class ShaderSettings {

        public ShaderSettings() { }
        public ShaderSettings(Shader defaultShader)
        {
            metallic = defaultShader;
            metallicBlend = defaultShader;
            specular = defaultShader;
            specularBlend = defaultShader;
        }

        public ShaderSettings(Material _overrideMaterial)
        {
            overrideMaterial = _overrideMaterial;
        }

        public Material overrideMaterial;

		[SerializeField] private Shader metallic;
		public Shader Metallic { get { return metallic != null ? metallic : (Shader.Find("GLTFUtility/Standard (Metallic)")??Shader.Find("Standard")); } }

		[SerializeField] private Shader metallicBlend;
		public Shader MetallicBlend { get { return metallicBlend != null ? metallicBlend : (Shader.Find("GLTFUtility/Standard Transparent (Metallic)") ?? Shader.Find("Standard")); } }

		[SerializeField] private Shader specular;
		public Shader Specular { get { return specular != null ? specular : (Shader.Find("GLTFUtility/Standard (Specular)") ?? Shader.Find("Standard")); } }

		[SerializeField] private Shader specularBlend;
		public Shader SpecularBlend { get { return specularBlend != null ? specularBlend : (Shader.Find("GLTFUtility/Standard Transparent (Specular)") ?? Shader.Find("Standard")); } }

		/// <summary> Caches default shaders so that async import won't try to search for them while on a separate thread </summary>
		public void CacheDefaultShaders() {

		}
	}
}