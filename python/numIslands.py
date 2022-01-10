isVisited=[[]] #col then rows
def numIslands(grid):
    isVisited=[[False for i in range(len(grid[0]))] for j in range(len(grid))]
    num=0
    #len(isVisited)->number of rows
    #len(isVisited[0])->number of cols
    ans=0
    # print(str(len(grid))+","+str(len(grid[0])))

    for row in range(len(grid)):
        for col in range(len(grid[0])):    
            
            stack=[]
            size=solver(row,col,grid,isVisited,0,stack)
            # print(str(row)+","+str(col)+"--->"+str(size))
            if size>0:
                ans=ans+1
    return ans


def solver(row,col,grid,isVisited,ans,stack):
    
    if row<0 or row>=len(grid):
        # print(str(row)+","+str(col)+"outside grid")
        return 0
    if col<0 or col>=len(grid[0]):
        return 0
    # print(str(row)+","+str(col)+"here")
    if isVisited[row][col]==True:
        # print(str(row)+","+str(col))
        return 0
    if grid[row][col]!="1":
        return 0

    store=[row,col]
    stack.append(store)
   
    # if grid[row][col]=="1":
    #     return 0
    isVisited[row][col]=True
    # grid[row][col]=ans+1
    up=solver(row-1,col,grid,isVisited,ans,stack)
    down=solver(row+1,col,grid,isVisited,ans,stack)
    left=solver(row,col-1,grid,isVisited,ans,stack)
    right=solver(row,col+1,grid,isVisited,ans,stack)
    
    return len(stack)

    # print(len(isVisited))
    # print(len(isVisited[0]))
    # print(isVisited)

# grid = [
#   ["1","1","1","1","0"],
#   ["1","1","0","1","0"],
#   ["1","1","0","0","0"],
#   ["0","0","0","0","0"]
# ]
grid = [
  ["1","1","0","0","1"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]

print(numIslands(grid))