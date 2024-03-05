/// @description Inserir descrição aqui
// Você pode escrever seu código neste editor
if(keyboard_check(vk_right)){
	image_angle= 270
	x += spd_ship 
	}
else if(keyboard_check(vk_left)){
	image_angle= 90
	x -= spd_ship
}
if(keyboard_check((vk_down))){
	image_angle= 180
	y += spd_ship
}
else if	(keyboard_check(vk_up)){
	image_angle= 0
	y -= spd_ship
}

