using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeSingleLoadOut : MonoBehaviour
{
    GameObject theOneClicked;

    Button alpha1Button;
    Button alpha2Button;
    Button alpha3Button;
    Button alpha4Button;
    Button beta1Button;
    Button beta2Button;
    Button beta3Button;
    Button beta4Button;

    GameObject alpha1Object;
    GameObject alpha2Object;
    GameObject alpha3Object;
    GameObject alpha4Object;

    GameObject beta1Object;
    GameObject beta2Object;
    GameObject beta3Object;
    GameObject beta4Object;

    Button assaultClassButton;
    Button supportClassButton;
    Button engineerClassButton;
    Button reconClassButton;

    GameObject assaultObject;
    GameObject supportObject;
    GameObject engineerObject;
    GameObject reconObject;


    public string stringtoChange;

    // Start is called before the first frame update
    void Start()
    {

        alpha1Object = GameObject.Find("Alpha1");
        alpha2Object = GameObject.Find("Alpha2");
        alpha3Object = GameObject.Find("Alpha3");
        alpha4Object = GameObject.Find("Alpha4");
        beta1Object = GameObject.Find("Beta1");
        beta2Object = GameObject.Find("Beta2");
        beta3Object = GameObject.Find("Beta3");
        beta4Object = GameObject.Find("Beta4");

        alpha1Button = alpha1Object.GetComponentInChildren<Button>();
        alpha2Button = alpha2Object.GetComponentInChildren<Button>();
        alpha3Button = alpha3Object.GetComponentInChildren<Button>();
        alpha4Button = alpha4Object.GetComponentInChildren<Button>(); 
        beta1Button = beta1Object.GetComponentInChildren<Button>();
        beta2Button = beta2Object.GetComponentInChildren<Button>();
        beta3Button = beta3Object.GetComponentInChildren<Button>();
        beta4Button = beta4Object.GetComponentInChildren<Button>();

        alpha1Button.onClick.AddListener(SetAlpha1);
        alpha2Button.onClick.AddListener(SetAlpha2);
        alpha3Button.onClick.AddListener(SetAlpha3);
        alpha4Button.onClick.AddListener(SetAlpha4);
        beta1Button.onClick.AddListener(SetBeta1);
        beta2Button.onClick.AddListener(SetBeta2);
        beta3Button.onClick.AddListener(SetBeta3);
        beta4Button.onClick.AddListener(SetBeta4);



        assaultObject = GameObject.Find("AssaultClass");
        supportObject = GameObject.Find("SupportClass");
        engineerObject = GameObject.Find("EngineerClass");
        reconObject = GameObject.Find("ReconClass");

        assaultClassButton = assaultObject.GetComponent<Button>();
        supportClassButton = supportObject.GetComponent<Button>();
        engineerClassButton = engineerObject.GetComponent<Button>();
        reconClassButton = reconObject.GetComponent<Button>();

        assaultClassButton.onClick.AddListener(SetAssaultClassString);
        supportClassButton.onClick.AddListener(SetSupportClassString);
        engineerClassButton.onClick.AddListener(SetEngineerClassString);
        reconClassButton.onClick.AddListener(SetReconClassString);




    }

    // Update is called once per frame
    void Update()
    {
        if(theOneClicked != null)
        {
            ChangeClass();
        }
    }



    public void ChangeClass()
    {
        
        theOneClicked.GetComponentInChildren<TextMeshProUGUI>().text = stringtoChange;
        /*
        if (stringtoChange == "Assault")
        {
            
        }
        else if(stringtoChange == "Support")
        {

        }
        else if(stringtoChange == "Engineer")
        {

        }
        else if(stringtoChange == "Recon")
        {

        }
        else
        {

        }
        */

    }

    public void SetAlpha1()
    {
        theOneClicked = GameObject.Find("Alpha1");
    }
    public void SetAlpha2()
    {
        theOneClicked = GameObject.Find("Alpha2");
    }
    public void SetAlpha3()
    {
        theOneClicked = GameObject.Find("Alpha3");
    }
    public void SetAlpha4()
    {
        theOneClicked = GameObject.Find("Alpha4");
    }
    public void SetBeta1()
    {
        theOneClicked = GameObject.Find("Beta1");
    }
    public void SetBeta2()
    {
        theOneClicked = GameObject.Find("Beta2");
    }
    public void SetBeta3()
    {
        theOneClicked = GameObject.Find("Beta3");
    }
    public void SetBeta4()
    {
        theOneClicked = GameObject.Find("Beta4");
    }

    public void SetAssaultClassString()
    {
        stringtoChange = "Assault";
    }
    public void SetSupportClassString()
    {
        stringtoChange = "Support";
    }
    public void SetEngineerClassString()
    {
        stringtoChange = "Engineer";
    }
    public void SetReconClassString()
    {
        stringtoChange = "Recon";
    }
}
