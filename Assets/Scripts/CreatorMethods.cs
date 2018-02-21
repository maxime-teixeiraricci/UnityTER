using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CreatorMethods{

    GameObject getNextAgentToCreate();

    void setNextAgentToCreate(GameObject nextAgentToCreate);

    bool isAbleToCreate(GameObject agent);

}
