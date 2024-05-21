#version 330 core

struct Material {
    sampler2D texture_diffuse1;
    sampler2D texture_specular1;
    //float shininess;
};

in vec2 TexCoords;

out vec4 FragColor;

uniform sampler2D texture_diffuse1;
uniform Material material;

void main() {
	FragColor = texture(texture_diffuse1, TexCoords);
}