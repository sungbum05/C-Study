#pragma once
#include<iostream>
#include<math.h>
#include<Windows.h>
struct Vector2D
{
	float x;
	float y;
	
	Vector2D():x(0.0f),y(0.0f){}//����Ʈ ������
	Vector2D(float a, float b):x(a),y(b){}//���ڰ� �ִ� ������

	//���� : ��Į�� ����
	// ���� ��꿡 �µ��� *= ������ �����ε�
	const Vector2D& operator*=(const float& rhs);
	// ���� ��꿡 �µ��� /= ������ �����ε�
	const Vector2D& operator/=(const float& rhs);

	//���� : ���� ����
	// ���� ��꿡 �µ��� += ������ �����ε�
	const Vector2D& operator+=(const Vector2D& rhs);
	// ���� ��꿡 �µ��� -= ������ �����ε�
	const Vector2D& operator-=(const Vector2D& rhs);

	//��
	// ���� ��꿡 �µ��� == ������ �����ε�
	bool operator==(const Vector2D& rhs)const;
	// ���� ��꿡 �µ��� != ������ �����ε�
	bool operator!=(const Vector2D& rhs)const;

	//���� x,y�� ���̸� ������ ��ȯ
	inline float Length()const{ return sqrt(x * x + y * y); }

	//���Ͱ� ����Ű�� �� ��ǥ ��ȯ
	float Dot(const Vector2D& v2)const;

	//Sign���� ���� �ٸ� enum�� ��ȯ
	int Sign(const Vector2D& v2)const;

	//���� ���Ͱ����� x,y�������� ���̸� ������ ��ȯ
	float Distance(const Vector2D& v2)const;

	//�� ���̸� ����ȭ �Ѥ���.
	void Normalize();

	//������ �ݴ밪 ��ȯ
	inline Vector2D Perp()const { return Vector2D(-y, x); }
};

//"Vector + x + y" �������� ����ϰ� �����ε� ����
std::ostream& operator<< (std::ostream& os, const Vector2D& rhs);
//x, y���� �Է� ���� �� �ְ� �����ε� ����
std::ifstream& operator>> (std::ifstream& is, Vector2D& lhs);

//�����ε��� *= ������ �̿��Ͽ� ���� ���� ��������
Vector2D operator*(const Vector2D& lhs, float rhs);
//������ �Է¹޴� ������ ����
Vector2D operator*(float lhs, const Vector2D& rhs);
//�����ε��� /= ������ �̿��Ͽ� ���� ���� ��������
Vector2D operator/(const Vector2D& lhs, float rhs);

//�����ε��� += ������ �̿��Ͽ� ���� ���� ��������
Vector2D operator+(const Vector2D& lhs,const Vector2D& rhs);
//�����ε��� -= ������ �̿��Ͽ� �� ���� ��������
Vector2D operator-(const Vector2D& lhs,const Vector2D& rhs);

//v1�� v2 �� ���� �Ÿ��� ������
float Vec2DDistance(const Vector2D& v1, const Vector2D& v2);

//���� ������ �Ÿ��� ����ȭ ��Ų��
Vector2D Vec2DNormalize(const Vector2D& v);

//���ͷ� ������ �޾� long�� ����Ʈ�� ��ȯ �Ѵ�.
POINT VectorToPOINT(const Vector2D& v);

//���ͷ� ������ �޾� short�� ����Ʈ�� ��ȯ �Ѵ�.
POINTS VectorToPOINTS(const Vector2D& v);

//����Ʈ�� ������ �޾� float�� ���ͷ� ��ȯ �Ѵ�.
Vector2D POINTtoVector(const POINT& p);

//����Ʈ�� ������ �޾� ���ͷ� ��ȯ �Ѵ�.
Vector2D POINTStoVector(const POINTS& p);

//���� x,y ���̸� ���������� ��ȯ�Ѵ�.
float Vec2DLengthSq(const Vector2D& v);

//������ x,y  ���̸� ��ȯ�Ѵ�.
float Vec2DLength(const Vector2D& v);

