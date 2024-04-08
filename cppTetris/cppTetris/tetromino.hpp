#pragma once

class Painter;

class Tetromino
{
public:
	enum Direction { LEFT = -1, RIGHT = 1 };
	enum Name { I, J, L, O, S, Z, T };
	// �������� ��������� �� �����
	Tetromino(Name);
	// ��������� ��������� �� ������������ Painter
	void draw(Painter &) const;
	// ����������� ��������� �� dx, dy
	void move(int dx, int dy);
	// ������� ��������� �� ������� ������� ��� 
	// ������ ������� �������
	void rotate(Direction);
	bool map(int x, int y) const;
	int x() const { return x_; }
	int y() const { return y_; }
private:
	Name name_;
	int angel_;
	int x_;
	int y_;
};
