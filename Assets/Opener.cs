using UnityEngine;

public class Opener : MonoBehaviour
{
    private Animator _animator;
    public GameObject OpenPanel = null;

    private bool _isInsideTrigger = false;

    public GameObject Panel = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();   
    }

    void OnTrggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _isInsideTrigger = true;
            OpenPanel.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            _isInsideTrigger = false;
            _animator.SetBool("Open", false);
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive{
        get{
            return OpenPanel.activeInHierarchy;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(IsOpenPanelActive && _isInsideTrigger){
            if(Input.GetKeyDown(KeyCode.E)){
                OpenPanel.SetActive(false);
                _animator.SetBool("Open", true);
            }
        }
    }
}
