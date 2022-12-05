using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSkill : MonoBehaviour
{
    [SerializeField] int skillNumber;

    public List<int> noUseSkill = new List<int>()
    {1,2,3,4,5};
    public int nUSSize = 5;
    public static bool cardDelete = false;

    void Start()
    {
        
    }

    
    void Update()
    {

        if(Count.otherSkillCount==skillNumber)
        {
            transform.position = new Vector3(-16, 0, 0);
        }

        if (Count.otherSkillCount == 0)
        {
            AiSkillUse();
        }
        noUseSkill.Remove(Count.otherSkillCount);
        CardDestroy();
    }

    void AiSkillUse()
    {
        if (TurnManager.turnCount == 2)
        {
            if (Count.otherNumberCount == 1)
            {
                if (Count.otherNumberCount == Count.myNumberCount)
                {
                    if (noUseSkill.Contains(1) && noUseSkill.Contains(5))
                    {
                        int i = Random.Range(1, 3);
                        if (i == 1)
                        {
                            Count.otherSkillCount = 1;
                        }
                        else if (i == 2)
                        {
                            Count.otherSkillCount = 5;
                        }
                    }
                    else if (!noUseSkill.Contains(1) && noUseSkill.Contains(5))
                    {
                        Count.otherSkillCount = 5;
                    }
                    else if (noUseSkill.Contains(1) && !noUseSkill.Contains(5))
                    {
                        Count.otherSkillCount = 1;
                    }
                    else if (!noUseSkill.Contains(1) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                }
                else if (Count.otherNumberCount < Count.myNumberCount)
                {
                    if(!noUseSkill.Contains(1)&& !noUseSkill.Contains(3)&&!noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while(Count.otherSkillCount==0)
                        {
                            int i = Random.Range(1, 4);
                            if(noUseSkill.Contains(1)&&i==1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(3)&&i==2)
                            {
                                Count.otherSkillCount = 3;
                            }
                            else if (noUseSkill.Contains(5)&&i==3)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
            }
            if(Count.otherNumberCount == 2)
            {
                if (Count.otherNumberCount > Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(4))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(4) && i == 2)
                            {
                                Count.otherSkillCount = 4;
                            }
                            
                        }
                    }
                }
                else if (Count.otherNumberCount == Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(5) && i == 2)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount < Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1)&&!noUseSkill.Contains(3) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 4);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(3) && i == 2)
                            {
                                Count.otherSkillCount = 3;
                            }
                            else if (noUseSkill.Contains(5) && i == 3)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
            }
            if(Count.otherNumberCount==3)
            {
                if (Count.otherNumberCount > Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(4))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(4) && i == 2)
                            {
                                Count.otherSkillCount = 4;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount == Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(5) && i == 2)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount < Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(2)&&!noUseSkill.Contains(3) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 5);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(2) && i == 2)
                            {
                                Count.otherSkillCount = 2;
                            }
                            else if (noUseSkill.Contains(3) && i == 3)
                            {
                                Count.otherSkillCount = 3;
                            }
                            else if (noUseSkill.Contains(5) && i == 4)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
            }
            if (Count.otherNumberCount == 4)
            {
                if (Count.otherNumberCount > Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(4))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(4) && i == 2)
                            {
                                Count.otherSkillCount = 4;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount == Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 3);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(5) && i == 2)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount < Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1) && !noUseSkill.Contains(2) && !noUseSkill.Contains(3) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 5);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(2) && i == 2)
                            {
                                Count.otherSkillCount = 2;
                            }
                            else if (noUseSkill.Contains(3) && i == 3)
                            {
                                Count.otherSkillCount = 3;
                            }
                            else if (noUseSkill.Contains(5) && i == 4)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
            }
            if (Count.otherNumberCount == 5)
            {
                if (Count.otherNumberCount > Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1)&&!noUseSkill.Contains(2) && !noUseSkill.Contains(4))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 4);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(2) && i == 2)
                            {
                                Count.otherSkillCount = 2;
                            }
                            else if (noUseSkill.Contains(4) && i == 3)
                            {
                                Count.otherSkillCount = 4;
                            }
                        }
                    }
                }
                else if (Count.otherNumberCount == Count.myNumberCount)
                {
                    if (!noUseSkill.Contains(1)&&!noUseSkill.Contains(2) && !noUseSkill.Contains(5))
                    {
                        RandomSkill();
                    }
                    else
                    {
                        while (Count.otherSkillCount == 0)
                        {
                            int i = Random.Range(1, 4);
                            if (noUseSkill.Contains(1) && i == 1)
                            {
                                Count.otherSkillCount = 1;
                            }
                            else if (noUseSkill.Contains(2) && i == 2)
                            {
                                Count.otherSkillCount = 2;
                            }
                            else if (noUseSkill.Contains(5) && i == 3)
                            {
                                Count.otherSkillCount = 5;
                            }
                        }
                    }
                }
            }
        }
    }

    void RandomSkill()
    {
        int i = Random.Range(0, nUSSize);
        Count.otherSkillCount = noUseSkill[i];
    }

    void CardDestroy()
    {
        if (cardDelete)
        {
            if (gameObject.transform.position == new Vector3(-16, 0, 0))
            {
                cardDelete = false;
                Destroy(gameObject);
            }
        }
    }
}
