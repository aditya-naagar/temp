# 1-D Array, peak finding using divide and conqure.

arr = [1,2,3,4,5,6,7,8,7,6,5,4,1,2,]
start, end = 0, len(arr) - 1

print("Array is: ", arr)

while(True):
	mid = (start + end) // 2
	if(mid == 0 or mid == (len(arr) - 1)):
		print("Peak found at ", mid, " peak is ", arr[mid])
		break
	if(arr[mid] < arr[mid + 1]):
		start = mid + 1
	elif(arr[mid] < arr[mid - 1]):
		end = mid
	else:
		print("Peak found at ", mid, " peak is ", arr[mid])
		break;
