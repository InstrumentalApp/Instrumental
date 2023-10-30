/* eslint-disable react/prop-types */
import styles from "../Styles/App";
import { Link } from "react-router-dom";

const HoverButton = ({
  children,
  onClick = null,
  link = null,
  backgroundColor = styles.colors.PRIMARY,
  color = "white",
  fontSize = "15px",
  fontWeight = color == styles.colors.BLACK ? "bold" : "normal",
  borderRadius = "50px",
  shadow = "4px 4px 0",
  shadowColor = styles.colors.BLACK,
  padding = "10px 25px",
  margin = "0",
  type="button", // "button" or "submit
  style,
  ...rest}) =>
{

  const buttonStyle = {
    padding: padding,
    margin: margin,
    boxShadow: `${shadow} ${shadowColor}`,
    color: color,
    backgroundColor: backgroundColor,
    border: `2.5px solid ${shadowColor}`,
    borderRadius: borderRadius,
    fontSize: fontSize,
    fontWeight: fontWeight,
    letterSpacing: "1px",
    transition: "translate .2s, box-shadow .25s",
  };

  // This will create the effect
  const hoverStyle = {
    translate: shadow,
    boxShadow: "none", 
  };
  
  const handleMouseOver = (e) => {
    e.currentTarget.style.translate = hoverStyle.translate;
    e.currentTarget.style.boxShadow = hoverStyle.boxShadow;
  }

  const handleMouseOut = (e) => {
    e.currentTarget.style.translate = "0 0 0";
    e.currentTarget.style.boxShadow = `${shadow} ${shadowColor}`;
  }

  return (
    <Link to={link}>
      <button
        {...rest}
        type={type}
        style={{ ...buttonStyle, ...(style || {}) }}
        onMouseOver={(e) =>
          handleMouseOver(e)
        }
        onMouseOut={(e) =>
          handleMouseOut(e)
        }
        onClick={onClick}
      >
        {children}
      </button>
    </Link>
  )
}

export default HoverButton;