# LowpassFilter
<p>It's a simple low pass filter with a single input and a single output.<br>
I also try second-order and third-order lowpass filter, but they seem the same.<br>
<br><br>
I use the formula from wiki:<br>
<a href="https://camo.githubusercontent.com/78c35a2e885fcf93b01f466f81aea12c511852b1/68747470733a2f2f77696b696d656469612e6f72672f6170692f726573745f76312f6d656469612f6d6174682f72656e6465722f7376672f35376161626535363764646332356135323232346131336661656163663939666539386461633164" target="_blank"><img src="https://camo.githubusercontent.com/78c35a2e885fcf93b01f466f81aea12c511852b1/68747470733a2f2f77696b696d656469612e6f72672f6170692f726573745f76312f6d656469612f6d6174682f72656e6465722f7376672f35376161626535363764646332356135323232346131336661656163663939666539386461633164" alt="y_i = \alpha x_i + (1 - \alpha) y_{i-1} \qquad \text{where} \qquad \alpha \triangleq \frac{\Delta_T}{RC + \Delta_T}" data-canonical-src="https://wikimedia.org/api/rest_v1/media/math/render/svg/57aabe567ddc25a52224a13faeacf99fe98dac1d" style="max-width:100%;"></a>
<br><br>
So It look like:<br></p>


    double Yp;

    public double firstOrder_lowpassFilter(double X, double beta)
    {
        double Y;

        Y = beta * X + (1 - beta) * Yp;

        Yp = Y;

        return Y;
    }

# How to use?
<p>1.You can just copy the method above.<br>
2.Use .dll in library folder.<br>
3.Download the project and add in to your project.<br></p>
<h1><a href="#example" aria-hidden="true" class="anchor" id="user-content-example"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Example</h1>
<p>You can open project in example folder.<br>
It's a simple lowpass filter demo.<br>
Just keep cliking "GO" button, and output will go closer to the input value you just enter.</p>
<p><br><br></p>
<h1><a href="#reference" aria-hidden="true" class="anchor" id="user-content-reference"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Reference:<br></h1>
<p><a href="https://en.wikipedia.org/wiki/Low-pass_filter">https://en.wikipedia.org/wiki/Low-pass_filter</a><br>
<a href="https://en.wikipedia.org/wiki/Exponential_smoothing">https://en.wikipedia.org/wiki/Exponential_smoothing</a><br></p>
