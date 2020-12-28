using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if PLATFORM_iOS
using UnityEngine.iOS;
#endif

#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class AppManager : MonoBehaviour {

    // Start is called before the first frame update
    void Start ( ) {

#if PLATFORM_ANDROID
        if ( !Permission.HasUserAuthorizedPermission ( Permission.ExternalStorageRead ) ) {

            Permission.RequestUserPermission ( Permission.ExternalStorageRead );

        }
#endif

    }

        // Update is called once per frame
        void Update() {

    }

    void ImageOptions_LoadImages() {
        if ( Permission.HasUserAuthorizedPermission ( Permission.ExternalStorageRead ) ) {
            for (int i=0; i<50; i++ ) {
                
            }
        }
    }

    //Button Actions
    void LoadImageOptions() => SceneManager.LoadScene("ImageOptions");
    void LoadMainMenu() => SceneManager.LoadScene("MainMenu");
    void Exit() => Application.Quit();
}
