using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BuilderMethods {

    GameObject getNextBuildingToBuild();
    
    void setNextBuildingToBuild(GameObject nextBuildingToBuild);
    
    bool isAbleToBuild(GameObject building);
    
    int getIdNextBuildingToRepair();
    
    void setIdNextBuildingToRepair(int idNextBuildingToRepair);

}
