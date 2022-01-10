def myPow( x, n):
    if n<0:
        return 1/pow(x,abs(n))
    if n==0:
        return 1
    return pow(x,n)
def pow(x,n):
    if n==1:
        return x
    return pow(x,n-1)*x

print(myPow(0.00001,2147483647))


# class Solution:
#     def myPow(self, x: float, n: int) -> float:
#         def recur(x,n):
#             if n==0:
#                 return 1
#             val = self.myPow(x,abs(n)//2)
#             if n%2==1:
#                 return val*val*x
#             return val*val
#         val = recur(x,n)
#         if n<0:
#             return 1/val
#         return val

