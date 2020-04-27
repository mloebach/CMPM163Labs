uniform sampler2D texture1;
varying vec2 vUv;
uniform float textureStyle;

void main() {
	// sample from the texture based on the uv coordinates
	//gl_FragColor = texture2D(texture1, vec2 mod(vUv * textureStyle, 1.0));
	vec2 wrapTexture = mod(vUv *textureStyle, 1.0);
	gl_FragColor = texture2D(texture1, wrapTexture);
}