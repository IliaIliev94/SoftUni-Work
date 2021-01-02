function solution(rectangleData) {
    let rectangles = rectangleData.map(([width, height]) => {
        return {
            width,
            height,
            area: function() {return this.height * this.width},
            compareTo: function(rectangle) {
                let difference = rectangle.area() - this.area();
                if(difference === 0) {
                    return rectangle.width - this.width;
                }
                return difference;
            }
        }
    });
    return rectangles.sort((a, b) => a.compareTo(b));
}

console.log(solution([[1,20],[20,1],[5,3],[5,3]]));