#pragma once

class Painter;
class Tetromino;

class Well
{
public:
	enum { WIDTH = 10, HEIGHT = 20 };
	Well();
	// ������ ������� �� ������������ Painter
	void draw(Painter &) const;
	// �������� �� ������������ ��������� � 
	// ������� � �������
	bool isCollision(const Tetromino &) const;
	// ������� ��������� � �������
	void unite(const Tetromino &);
	// �������� ��������� ���������� ������
	int removeSolidLines();
private:
	bool map_[HEIGHT][WIDTH];
};

