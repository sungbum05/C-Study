#pragma once
#include<iostream>
#include<math.h>
#include<Windows.h>
struct Vector2D
{
	float x;
	float y;
	
	Vector2D():x(0.0f),y(0.0f){}//디폴트 생성자
	Vector2D(float a, float b):x(a),y(b){}//인자가 있는 생성자

	//벡터 : 스칼라 연산
	// 벡터 계산에 맞도록 *= 연산자 오버로딩
	const Vector2D& operator*=(const float& rhs);
	// 벡터 계산에 맞도록 /= 연산자 오버로딩
	const Vector2D& operator/=(const float& rhs);

	//벡터 : 벡터 연산
	// 벡터 계산에 맞도록 += 연산자 오버로딩
	const Vector2D& operator+=(const Vector2D& rhs);
	// 벡터 계산에 맞도록 -= 연산자 오버로딩
	const Vector2D& operator-=(const Vector2D& rhs);

	//비교
	// 벡터 계산에 맞도록 == 연산자 오버로딩
	bool operator==(const Vector2D& rhs)const;
	// 벡터 계산에 맞도록 != 연산자 오버로딩
	bool operator!=(const Vector2D& rhs)const;

	//벡터 x,y의 길이를 제곱근 반환
	inline float Length()const{ return sqrt(x * x + y * y); }

	//벡터가 가리키는 점 좌표 반환
	float Dot(const Vector2D& v2)const;

	//Sign값의 따라 다른 enum값 반환
	int Sign(const Vector2D& v2)const;

	//받은 벡터값에서 x,y값까지의 길이를 제곱근 반환
	float Distance(const Vector2D& v2)const;

	//위 길이를 정규화 한ㄴ다.
	void Normalize();

	//벡터의 반대값 반환
	inline Vector2D Perp()const { return Vector2D(-y, x); }
};

//"Vector + x + y" 형식으로 출력하게 오버로딩 해줌
std::ostream& operator<< (std::ostream& os, const Vector2D& rhs);
//x, y값을 입력 받을 수 있게 오버로딩 해줌
std::ifstream& operator>> (std::ifstream& is, Vector2D& lhs);

//오버로딩한 *= 연산을 이용하여 곱한 값을 리턴해줌
Vector2D operator*(const Vector2D& lhs, float rhs);
//위에와 입력받는 순서의 차이
Vector2D operator*(float lhs, const Vector2D& rhs);
//오버로딩한 /= 연산을 이용하여 나눈 값을 리턴해줌
Vector2D operator/(const Vector2D& lhs, float rhs);

//오버로딩한 += 연산을 이용하여 더한 값을 리턴해줌
Vector2D operator+(const Vector2D& lhs,const Vector2D& rhs);
//오버로딩한 -= 연산을 이용하여 뺀 값을 리턴해줌
Vector2D operator-(const Vector2D& lhs,const Vector2D& rhs);

//v1과 v2 두 점의 거리를 구해줌
float Vec2DDistance(const Vector2D& v1, const Vector2D& v2);

//두점 사이의 거리를 정규화 시킨다
Vector2D Vec2DNormalize(const Vector2D& v);

//벡터로 두점을 받아 long형 포인트로 반환 한다.
POINT VectorToPOINT(const Vector2D& v);

//벡터로 두점을 받아 short형 포인트로 반환 한다.
POINTS VectorToPOINTS(const Vector2D& v);

//포인트로 두점을 받아 float형 벡터로 반환 한다.
Vector2D POINTtoVector(const POINT& p);

//포인트로 두점을 받아 벡터로 반환 한다.
Vector2D POINTStoVector(const POINTS& p);

//벡터 x,y 길이를 제곱근으로 반환한다.
float Vec2DLengthSq(const Vector2D& v);

//벡터의 x,y  길이를 반환한다.
float Vec2DLength(const Vector2D& v);

