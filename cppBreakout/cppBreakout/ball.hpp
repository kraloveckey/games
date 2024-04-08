#pragma once
#include "force.hpp"

class Painter;

class Ball
{
public:
	static const float DT;
	Ball();
	void draw(Painter &) const;
	float x() const { return x_; }
	float y() const { return y_; }
	void tick(Force);
private:
	float x_;
	float y_;
	float vx_;
	float vy_;


};
