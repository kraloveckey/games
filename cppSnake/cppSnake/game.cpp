#include "painter.hpp"
#include "game.hpp"
#include "field.hpp"
#include "snake.hpp"
#include "GL/glut.h"

void Game::tick()
{
	if (!snake_.tick(field_))
	{
		snake_ = Snake();
		field_ = Field();
	}
}

void Game::draw(Painter &p) const
{
	field_.draw(p);
}

void Game::keyEvent(Snake::Direction d)
{
	snake_.keyEvent(d);
}
