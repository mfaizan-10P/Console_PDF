﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace Console_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = @"<!DOCTYPE html>
                                <html>
                                  <head>
                                    <meta charset='utf-8' />
                                    <title>PDF</title>
                                  </head>
                                  <body>
                                    <div class='TopArea'>
                                      <div class='container' style='width: 100%; margin: 0 auto'>
                                        <table
                                          style='border-collapse: collapse; table-layout: fixed; margin: 0 auto'
                                          cellspacing='0'
                                          cellpadding='0'
                                        >
                                          <tbody>
                                            <tr>
                                              <td style='width: 310px; text-align: center'>
                                                <a
                                                  style='
                                                    font-size: 20px;
                                                    text-decoration: none;
                                                    color: #000;
                                                    font-weight: 600;
                                                    margin-left: 10px;
                                                  '
                                                  href='/'
                                                  >Shop 24/7 - annemcgilvray.com</a
                                                >
                                              </td>
                                              <td style='width: 310px; text-align: center'>
                                                <a
                                                  style='
                                                    font-size: 20px;
                                                    text-decoration: none;
                                                    color: #000;
                                                    font-weight: 600;
                                                  '
                                                  href=''
                                                  >Follow Us - @annemcgilvrayco</a
                                                >
                                              </td>
                                              <td style='width: 310px'>
                                                <a
                                                  style='
                                                    margin-left: 25px;
                                                    display: block;
                                                    color: #1e1e1e;
                                                    font-size: 20px;
                                                    font-weight: 600;
                                                    padding-bottom: 10px;
                                                    text-decoration: none;
                                                  '
                                                  href=''
                                                  >Customer Service - 800.527.1462 x1</a
                                                >
                                              </td>
                                              <td style='width: 150px'>
                                                <img
                                                  style='width: 50; height: 50px; margin-left: 20px'
                                                  src='D:\Work\AMCI\AMCI DevOps\WOWCommerce\Content\themes\Skin_Default\images\logo.png'
                                                />
                                              </td>
                                            </tr>
                                          </tbody>
                                        </table>
                                      </div>
                                      <br /><img
                                        style='width: 100%'
                                        src='D:\Work\AMCI\AMCI DevOps\WOWCommerce\Content\themes\Skin_Default\images\anne\single-border.png'
                                      /><br />
                                    </div>

                                    <div class='header' style='width: 100%; margin: 30px auto 30px'>
                                      <table
                                        style='
                                          border-collapse: collapse;
                                          width: 90%;
                                          margin-left: 50px;
                                          margin-right: auto;
                                          table-layout: fixed;
                                        '
                                        cellspacing='0'
                                        cellpadding='0'
                                      >
                                        <tbody>
                                          <tr>
                                            <td style='width: 200px'>
                                              <div class='thumb' style='float: left'>
                                                <img
                                                  style='height: 200px; width: 200px; float: left'
                                                  src='https://annemcgilvray.com/contentassets/bab1c102ae9c4e3c822d5da9a651e8ed/cary-clemence---headshot.jpg'
                                                />
                                              </div>
                                            </td>
                                            <td style='width: 350px'>
                                              <div class='details' style='float: left; margin: 0px 0 10px 20px'>
                                                <h1
                                                  style='
                                                    font-weight: 600;
                                                    font-size: 40px;
                                                    margin: 0;
                                                    padding: 0;
                                                  '
                                                >
                                                  Cary Clemence
                                                </h1>
                                                <ul style='padding: 0; margin: 0 0 10px'>
                                                  <li
                                                    style='list-style: none; display: block; padding-top: 8px'
                                                  >
                                                    <span style='float: left; margin-right: 10px'>
                                                      <img
                                                        style='width: 22px; height: 28px'
                                                        src='D:\Work\AMCI\AMCI DevOps\WOWCommerce\Content\themes\Skin_Default\images\anne\location.png'
                                                      /> </span
                                                    ><span style='font-weight: 600; font-size: 26px'
                                                      >Texas (West)</span
                                                    >
                                                  </li>
                                                  <li
                                                    style='list-style: none; display: block; padding-top: 8px'
                                                  >
                                                    <a
                                                      style='
                                                        float: left;
                                                        color: #1e1e1e;
                                                        font-size: 16px;
                                                        text-decoration: none;
                                                        padding: 0;
                                                        display: block;
                                                      '
                                                      href=''
                                                    >
                                                      <span style='float: left; margin-right: 10px'>
                                                        <img
                                                          style='width: 20px; height: 20px'
                                                          src='D:\Work\AMCI\AMCI DevOps\WOWCommerce\Content\themes\Skin_Default\images\anne\phone.png'
                                                        /> </span
                                                      >806.331.3636
                                                    </a>
                                                  </li>
                                                  <li style='list-style: none; display: block'>
                                                    <a
                                                      style='
                                                        float: left;
                                                        color: #1e1e1e;
                                                        font-size: 16px;
                                                        text-decoration: none;
                                                        background-position: 0 10px;
                                                        padding: 10px 0px;
                                                        display: block;
                                                      '
                                                      href=''
                                                    >
                                                      <span style='float: left; margin-right: 10px'>
                                                        <img
                                                          style='width: 20px; height: 20px'
                                                          src='D:\Work\AMCI\AMCI DevOps\WOWCommerce\Content\themes\Skin_Default\images\anne\mail.png'
                                                        /> </span
                                                      >cclemence@annemcgilvray.com
                                                    </a>
                                                  </li>
                                                </ul>
                                              </div>
                                            </td>
                                            <td style='text-align: left'>
                                              <div class='right-area' style='float: left'>
                                                <div class='qr-code' style='float: left; margin-top: 40px'>
                                                  <img
                                                    style='float: right'
                                                    width='120'
                                                    height='120'
                                                    src='data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAABkCAYAAABw4pVUAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAASkSURBVHhe7ZFBjiRBCAPn/5/e1UhrCYXKQ1KdzHIgJB9sKDppvv4so9iDDGMPMow9yDD2IMPYgwxjDzKMPcgw9iDD2IMMYw8yjD3IMPYgw9iDDGMPMow9yDD2IMPYgwxjDzKMPcgw9iDDaDnI19fXKxFXpxdZflo/VQctU58efyLi6vQiy0/rp+qgZWr1wex332e5q2dUv3v7Oye0TP10Qfd9lrt6RvW7t79zQstUPlieEs5TVfhdnPWUi9gTJehv0jLVLUAJ56kq/C7OespF7IkS9DdpmeoWoAS9iL1PEi4XLhesy1OC/iYtU90ClKAXsfdJwuXC5YJ1eUrQ36RlqluAEpkXyt9KnHpK0N+kZapbgBKZF8rfSpx6StDfpGVq9cHsl2dO2CeJp9q3iMsd1f4KLVM/XVCeOWGfJJ5q3yIud1T7K7RM1YOrEv/LV9VBy9Snx59I/C9fVQc9Uz+kurjrd/lk9iDDaHml+yPoReyt1LOcxN5YZy4Jl3fQMt0tQC9ib6We5ST2xjpzSbi8g97p/+Ai1cVu96tOkWp+g56pgAtUF7rdrzpFqvkNeqYeosXcgm/r9ML1VdVJ7/SEbNG3dXrh+qrqpHW6W6SaE9d3mksky139Jq3T3SLVnLi+01wiWe7qN2mdni0Ql3wSYe68k3iqfYswj70xv0nP1H9kD4/LPYkwd95JPNW+RZjH3pjfpGfqP/jwuEzMBfPYG3Nxmss7TaL1NVw4/gkxF8xjb8zFaS7vNImW11QXZp/7TjnrVU9UZx9zqoOWqdWHs899p5z1qieqs4851UHL1LcPZ3+c8ZNE5h3uO5d30jI9LlNZgP1xxk8SmXe471zeSev0uFRcJPMZWb/qToI+o9r/htbpWoCLZD4j61fdSdBnVPvf0Du9iFtYuRNhnvVRgl64/AY9U1+S/QFOhHnWRwl64fIbtEzlg089JehF7H2qO/idlFHtf0PLVD741FOCXsTep7qD30kZ1f439Ew1cCGJMI+9MReu7jxz4urx26f6DXqmGriQRJjH3pgLV3eeOXH1+O1T/QYtU/ngqhfKWXe5YO58JkHfScuvZAtlXihn3eWCufOZBH0nv/MrRdwfQgnnKUFPXD/VQc/UD+HC8U+IEs5Tgp64fqqDlqlPjz+RoCdZPYPfZ164/CYt0/XwqgQ9yeoZ/D7zwuU3aZlefbjrV57Vq2TfqZ6pg5ap1Qe7fuVZvUr2neqZOmiZygfHJaIEvYi9P9Ud8dvYx9zJkdU/oWUqHyxPCXoRe3+qO+K3sY+5kyOrf0LLVD5YnhLOUyLzQrmrC/Y5/QYtv8IF4lJRwnlKZF4od3XBPqffoOVXuEBcKkrQi6yP3qE+yvHU+y1Bf5OWqW4BStCLrI/eoT7K8dT7LUF/k5ap1QezX/5U5KnnRBmnfZ/QMr36cPbLn4o89Zwo47TvE1qmxyUrEvTE1ZnLn+bC1ek7aJkel6lI0BNXZy5/mgtXp++gd/pSZg8yjD3IMPYgw9iDDGMPMow9yDD2IMPYgwxjDzKMPcgw9iDD2IMMYw8yjD3IMPYgw9iDDGMPMow9yDD2IMPYg4ziz5+/JgoPaSQPCbIAAAAASUVORK5CYII='
                                                  />
                                                </div>
                                              </div>
                                            </td>
                                          </tr>
                                          <tr>
                                            <td colspan='3'>
                                              <p style='font-style: italic'>
                                                For reps covering multiple territories, not all lines listed may
                                                be represented in all territories. Please contact each rep for
                                                their territory-specific line lists.
                                              </p>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                    </div>
                                    <div class='main-area' style='width: 100%; height: 100vh; margin: 30px 0 0'>
                                      <table
                                        style='
                                          border-collapse: collapse;
                                          width: 90%;
                                          margin-left: 50px;
                                          margin-right: auto;
                                          table-layout: fixed;
                                        '
                                        cellspacing='0'
                                        cellpadding='0'
                                      >
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Abrams</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Andrews Mcmeel Universal</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Archie McPhee Wholesale</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Ata-Boy</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Atlas Screen Printing</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Badge Bomb!</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Balvi</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >BigMouth</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Blossom Beauty</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Blue Q</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Cassidy Labs</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Charm It!</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Chronicle Books</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >City Bonfires</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Clever Idiots</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Color Box Design & Letterpress</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Core Home</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Crocodile Creek</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >D & D Distributing</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Douglas Company Inc.</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Dover Publications</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >eeBoo</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Elum Designs</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Ephemera</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Found Image Press</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Fred and Friends</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Fringe Studio</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Funatic</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >garb2ART Cosmetics</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Gibbs Smith</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Ginger Fox</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Gotta Get It Gifts</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Grandpa Joe's Candy Shop</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Graphique</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Great Stuff Novelties</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Hachette Book Group</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Ingram Publisher Services</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >IPG</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Iscream</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Joy Creative Shop</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >KIKKERLAND DESIGN</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Klutz Inc.</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >L10 Brands</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >La-a Sole</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >LuxCups Creative</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Macmillan</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Madd Capp Games & Puzzles</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Made Happy</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Make Believe Ideas</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Mideer</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >My Mini Cosmo</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Nice Enough Stickers</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >NMR Distribution America</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Northern Lights Candles</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Noted</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >NPW Group</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Odd Sox</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Out Of Print</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Paladone</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Parragon</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Penguin Random House</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Pez Candy</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Pink Poppy</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Pipsticks</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Project Genius</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Quarto</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Salt N Rays</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Scholastic</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Simon & Schuster</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Sleeping Bear Press</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Smith & Sinclair</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Sourcebooks</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Speedy Monkey</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Spoontiques</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Streamline</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Suck UK</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Sunnie Lane</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >The Type Set Co.</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >True South Puzzle Company</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Unemployed Philosophers Guild</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Union Square & Co.</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >Whiskey River Soap Company</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 14px;
                                              padding-bottom: 14px;
                                              width: 20%;
                                              text-align: left;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              >White Mountain Puzzles</a
                                            >
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                          <td
                                            style='
                                              padding-left: 0px;
                                              padding-right: 37px;
                                              padding-top: 18px;
                                              padding-bottom: 18px;
                                              width: 20%;
                                              text-align: center;
                                            '
                                          >
                                            <a
                                              style='
                                                font-size: 20px;
                                                text-decoration: none;
                                                color: #1e1e1e;
                                                font-weight: 600;
                                              '
                                              href='javascript:;'
                                              ><span style='display: block; margin-bottom: 5px'></span
                                            ></a>
                                          </td>
                                        </tr>
                                      </table>
                                    </div>
                                  </body>
                                </html>
                                ";

            string htmlContent = ReadHtmlFile("PdfContent.html");
            //using (MemoryStream stream = new System.IO.MemoryStream())
            //{
            //    var outputpath = Guid.NewGuid().ToString() + ".pdf";
            //    var sr = new StringReader(content);
            //    var pdfDoc = new Document();
            //    // Create a CSS resolver
            //    var cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(true);
            //    var writer = PdfWriter.GetInstance(pdfDoc, new FileStream(outputpath, FileMode.Create));
            //    pdfDoc.Open();
            //    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            //    pdfDoc.Close();

            //    //return File(stream.ToArray(), "application/pdf", model.SearchResults[0].FullName + ".pdf");
            //}

            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(htmlContent, new PdfGenerateConfig()
                {
                    PageSize = PdfSharp.PageSize.A2,
                    PageOrientation = PdfSharp.PageOrientation.Portrait
                }, null);
                pdf.AddPage(new PdfSharp.Pdf.PdfPage(new PdfSharp.Pdf.PdfDocument();
                //var pdf = PdfGenerator.GeneratePdf(content.ToString(), PdfSharp.PageSize.A4);
                pdf.Save("art_" + Guid.NewGuid().ToString() + ".pdf");
                //pdf.Save(ms);
                //res = ms.ToArray();
            }
        }

        static string ReadHtmlFile(string filePath)
        {
            try
            {
                // Read the contents of the file into a string
                string htmlContent = File.ReadAllText(filePath);
                return htmlContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
